﻿using System;
using System.Collections.Generic;
namespace DocumentManagingSystem
{
    public class DocumentSystem
    {
        private static List<Document> allDocuments = new List<Document>();

        public static IList<string> ReadAllCommands()
        {
            List<string> commands = new List<string>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "")
                {
                    // End of commands
                    break;
                }
                commands.Add(commandLine);
            }
            return commands;
        }

        public static void ExecuteCommands(IList<string> commands)
        {
            foreach (var commandLine in commands)
            {
                int paramsStartIndex = commandLine.IndexOf("[");
                string cmd = commandLine.Substring(0, paramsStartIndex);
                int paramsEndIndex = commandLine.IndexOf("]");
                string parameters = commandLine.Substring(
                    paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
                ExecuteCommand(cmd, parameters);
            }
        }

        private static void ExecuteCommand(string cmd, string parameters)
        {
            string[] cmdAttributes = parameters.Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (cmd == "AddTextDocument")
            {
                AddTextDocument(cmdAttributes);
            }
            else if (cmd == "AddPDFDocument")
            {
                AddPdfDocument(cmdAttributes);
            }
            else if (cmd == "AddWordDocument")
            {
                AddWordDocument(cmdAttributes);
            }
            else if (cmd == "AddExcelDocument")
            {
                AddExcelDocument(cmdAttributes);
            }
            else if (cmd == "AddAudioDocument")
            {
                AddAudioDocument(cmdAttributes);
            }
            else if (cmd == "AddVideoDocument")
            {
                AddVideoDocument(cmdAttributes);
            }
            else if (cmd == "ListDocuments")
            {
                ListDocuments();
            }
            else if (cmd == "EncryptDocument")
            {
                EncryptDocument(parameters);
            }
            else if (cmd == "DecryptDocument")
            {
                DecryptDocument(parameters);
            }
            else if (cmd == "EncryptAllDocuments")
            {
                EncryptAllDocuments();
            }
            else if (cmd == "ChangeContent")
            {
                ChangeContent(cmdAttributes[0], cmdAttributes[1]);
            }
            else
            {
                throw new InvalidOperationException("Invalid command: " + cmd);
            }
        }

        private static void AddTextDocument(string[] attributes)
        {
            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();
            if (attributes.Length > 0)
            {
                foreach (var attr in attributes)
                {
                    parameters.Add(new KeyValuePair<string, object>(attr.Split('=')[0], attr.Split('=')[1]));
                }

                var name = parameters.Find(x => x.Key == "name");
                if (name.Key != null)
                {
                    parameters.RemoveAll(x => x.Key == "name");
                    Document newDoc = new TextDocument(name.Value.ToString());
                    foreach (var param in parameters)
                    {
                        newDoc.LoadProperty(param.Key, param.Value.ToString());
                    }

                    allDocuments.Add(newDoc);
                    Console.WriteLine("Document added: {0}", newDoc.Name);
                }
                else
                {
                    Console.WriteLine("Document has no name");
                }

            }
            else
            {
                Console.WriteLine("Document has no name");
            }

        }

        private static void AddPdfDocument(string[] attributes)
        {
            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();
            if (attributes.Length > 0)
            {
                foreach (var attr in attributes)
                {
                    parameters.Add(new KeyValuePair<string, object>(attr.Split('=')[0], attr.Split('=')[1]));
                }

                var name = parameters.Find(x => x.Key == "name");
                if (name.Key != null)
                {
                    parameters.RemoveAll(x => x.Key == "name");
                    Document newDoc = new PDFDocument(name.Value.ToString());
                    foreach (var param in parameters)
                    {
                        newDoc.LoadProperty(param.Key, param.Value.ToString());
                    }

                    allDocuments.Add(newDoc);
                    Console.WriteLine("Document added: {0}", newDoc.Name);
                }
                else
                {
                    Console.WriteLine("Document has no name");
                }

            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddWordDocument(string[] attributes)
        {
            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();
            if (attributes.Length > 0)
            {
                foreach (var attr in attributes)
                {
                    parameters.Add(new KeyValuePair<string, object>(attr.Split('=')[0], attr.Split('=')[1]));
                }

                var name = parameters.Find(x => x.Key == "name");
                if (name.Key != null)
                {
                    parameters.RemoveAll(x => x.Key == "name");
                    Document newDoc = new WordDocument(name.Value.ToString());
                    foreach (var param in parameters)
                    {
                        newDoc.LoadProperty(param.Key, param.Value.ToString());
                    }

                    allDocuments.Add(newDoc);
                    Console.WriteLine("Document added: {0}", newDoc.Name);
                }
                else
                {
                    Console.WriteLine("Document has no name");
                }

            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddExcelDocument(string[] attributes)
        {
            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();
            if (attributes.Length > 0)
            {
                foreach (var attr in attributes)
                {
                    parameters.Add(new KeyValuePair<string, object>(attr.Split('=')[0], attr.Split('=')[1]));
                }

                var name = parameters.Find(x => x.Key == "name");
                if (name.Key != null)
                {
                    parameters.RemoveAll(x => x.Key == "name");
                    Document newDoc = new ExcelDocument(name.Value.ToString());
                    foreach (var param in parameters)
                    {
                        newDoc.LoadProperty(param.Key, param.Value.ToString());
                    }

                    allDocuments.Add(newDoc);
                    Console.WriteLine("Document added: {0}", newDoc.Name);
                }
                else
                {
                    Console.WriteLine("Document has no name");
                }

            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddAudioDocument(string[] attributes)
        {
            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();
            if (attributes.Length > 0)
            {
                foreach (var attr in attributes)
                {
                    parameters.Add(new KeyValuePair<string, object>(attr.Split('=')[0], attr.Split('=')[1]));
                }

                var name = parameters.Find(x => x.Key == "name");
                if (name.Key != null)
                {
                    parameters.RemoveAll(x => x.Key == "name");
                    Document newDoc = new AudioDocument(name.Value.ToString());
                    foreach (var param in parameters)
                    {
                        newDoc.LoadProperty(param.Key, param.Value.ToString());
                    }

                    allDocuments.Add(newDoc);
                    Console.WriteLine("Document added: {0}", newDoc.Name);
                }
                else
                {
                    Console.WriteLine("Document has no name");
                }

            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddVideoDocument(string[] attributes)
        {
            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();
            if (attributes.Length > 0)
            {
                foreach (var attr in attributes)
                {
                    parameters.Add(new KeyValuePair<string, object>(attr.Split('=')[0], attr.Split('=')[1]));
                }

                var name = parameters.Find(x => x.Key == "name");
                if (name.Key != null)
                {
                    parameters.RemoveAll(x => x.Key == "name");
                    Document newDoc = new VideoDocument(name.Value.ToString());
                    foreach (var param in parameters)
                    {
                        newDoc.LoadProperty(param.Key, param.Value.ToString());
                    }

                    allDocuments.Add(newDoc);
                    Console.WriteLine("Document added: {0}", newDoc.Name);
                }
                else
                {
                    Console.WriteLine("Document has no name");
                }

            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void ListDocuments()
        {
            if (allDocuments.Count > 0)
            {
                foreach (var docu in allDocuments)
                {
                    Console.WriteLine(docu);
                }
            }
            else
            {
                Console.WriteLine("No documents found");
            }
        }

        private static void EncryptDocument(string name)
        {
            var documentsToEncrypt = allDocuments.FindAll(x => x.Name == name);
            if (documentsToEncrypt.Count > 0)
            {
                foreach (var doc in documentsToEncrypt)
                {
                    if (doc is EncryptableDocument)
                    {
                        (doc as EncryptableDocument).Encrypt();
                        Console.WriteLine("Document encrypted: {0}", name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support encryption: {0}", name);
                    }
                }
            }
            else
            {
                Console.WriteLine("Document not found: {0}", name);
            }
        }

        private static void DecryptDocument(string name)
        {
            var documentsToDecrypt = allDocuments.FindAll(x => x.Name == name);
            if (documentsToDecrypt.Count > 0)
            {
                foreach (var doc in documentsToDecrypt)
                {
                    if (doc is EncryptableDocument)
                    {
                        (doc as EncryptableDocument).Decrypt();
                        Console.WriteLine("Document Decrypted: {0}", name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support encryption: {0}", name);
                    }
                }
            }
            else
            {
                Console.WriteLine("Document not found: {0}", name);
            }
        }

        private static void EncryptAllDocuments()
        {
            var encryptableDocs = allDocuments.FindAll(x => x is EncryptableDocument);
            if (encryptableDocs.Count == 0)
            {
                Console.WriteLine("No encryptable documents found");
            }
            else
            {
                foreach (var doc in encryptableDocs)
                {
                    (doc as EncryptableDocument).Encrypt();
                }
                Console.WriteLine("All documents encrypted");
            }

        }

        private static void ChangeContent(string name, string content)
        {
            var filesToChange = allDocuments.FindAll(x => x.Name == name);
            if (filesToChange.Count > 0)
            {
                foreach (var file in filesToChange)
                {
                    if (file is IEditable)
                    {
                        (file as IEditable).ChangeContent(content);
                        Console.WriteLine("Document content changed: {0}", name);
                    }
                    else
                    {
                        Console.WriteLine("Document is not editable: {0}", name);
                    }
                }
            }
            else
            {
                Console.WriteLine("Document not found: {0}", name);
            }
        }

    }
}