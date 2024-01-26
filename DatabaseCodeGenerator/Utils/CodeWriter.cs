﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace DatabaseCodeGenerator.Utils
{
    public class CodeWriter
    {
        private HashSet<string> _writtenFiles;
        public CodeWriter(string rootFolder)
        {
            Assert.IsNotNull(rootFolder);
            Assert.IsNotEmpty(rootFolder);

            _rootFolder = rootFolder;
            _writtenFiles = new HashSet<string>();
        }

        public void Write(string ns, string filename, string content)
        {
            var fullpath = Path.Combine(_rootFolder, ns.Replace(".", "/"));
            Directory.CreateDirectory(fullpath);
            var path = Path.GetFullPath(Path.Combine(fullpath, filename + Ext));
            File.WriteAllText(path, content);
            _writtenFiles.Add(path);
        }

        public void DeleteOldFiles()
        {
            try
            {
                DeleteFilesWithExtension(_rootFolder, ".cs", _writtenFiles);
            }
            catch (DirectoryNotFoundException e)
            {
                return;
            }
        }
        
        private static void DeleteFilesWithExtension(string path, string extension, HashSet<String> exceptions)
        {
            // Do not follow symlinks to avoid escaping outside of the generated dir
            if (IsSymbolic(path)) return;
            // Process files in the current directory
            foreach (var file in Directory.EnumerateFiles(path))
            {
                var fullPath = Path.GetFullPath(file);
                if (!Path.GetExtension(file).Equals(extension, StringComparison.OrdinalIgnoreCase)) continue;
                if(exceptions.Contains(fullPath)) continue;
                Console.WriteLine($"Deleting old file: {fullPath}");
                File.Delete(file);
            }

            // Recursively process subdirectories
            foreach (var directory in Directory.EnumerateDirectories(path))
            {
                DeleteFilesWithExtension(directory, extension, exceptions);
            }
        }
        
        private static bool IsSymbolic(string path)
        {
            var pathInfo = new FileInfo(path);
            return pathInfo.Attributes.HasFlag(FileAttributes.ReparsePoint);
        }

        private readonly string _rootFolder;
        private const string Ext = ".cs";
    }
}
