﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sledge.Packages.Pak
{
    // http://quakewiki.org/wiki/.pak
    public class PakPackage : IDisposable
    {
        private const string Signature = "PACK";

        public FileInfo File { get; private set; }
        internal int TreeOffset { get; private set; }
        internal int TreeLength { get; private set; }
        internal List<PakEntry> Entries { get; private set; }

        public PakPackage(FileInfo file)
        {
            File = file;
            Entries = new List<PakEntry>();

            // Read the data from the pak
            using (var br = new BinaryReader(OpenFile(file)))
            {
                var sig = br.ReadFixedLengthString(Encoding.ASCII, 4);
                if (sig != Signature) throw new PackageException("Unknown package signature: Expected '" + Signature + "', got '" + sig + "'.");

                TreeOffset = br.ReadInt32();
                TreeLength = br.ReadInt32();

                // Read all the entries from the pak
                ReadDirectoryEntries(br);
            }
        }
        
        internal FileStream OpenFile(FileInfo file)
        {
            return new FileStream(file.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 4096, FileOptions.RandomAccess);
        }

        private void ReadDirectoryEntries(BinaryReader br)
        {
            br.BaseStream.Position = TreeOffset;
            var numEntries = TreeLength / 64;
            for (int i = 0; i < numEntries; i++)
            {
                var path = br.ReadFixedLengthString(Encoding.ASCII, 56);
                var offset = br.ReadInt32();
                var length = br.ReadInt32();
                Entries.Add(new PakEntry(path, offset, length));
            }
        }

        public IEnumerable<PakEntry> GetEntries()
        {
            return Entries;
        }

        public byte[] ExtractEntry(PakEntry entry)
        {
            using (var sr = new BinaryReader(OpenStream(entry)))
            {
                return sr.ReadBytes(entry.Length);
            }
        }

        public Stream OpenStream(PakEntry entry)
        {
            return new SubStream(OpenFile(File), entry.Offset, entry.Length) { CloseParentOnDispose = true };
        }

        public IPackageStreamSource GetStreamSource()
        {
            return new PakPackageStreamSource(this);
        }

        public void Dispose()
        {
            Entries.Clear();
        }
    }
}
