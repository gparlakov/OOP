using System;
using System.Collections.Generic;

public class DocumentSystem
{
    private static List<Document> allDocuments = new List<Document>();

    static void Main()
    {
        IList<string> allCommands = ReadAllCommands();
        ExecuteCommands(allCommands);
    }

    private static IList<string> ReadAllCommands()
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

    private static void ExecuteCommands(IList<string> commands)
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
        List<KeyValuePair<string, object>> attributesSplit = ParseAttributes(attributes);

        var name = attributesSplit.Find(x => x.Key == "name");
        if (name.Key != null)
        {
            Document newDoc = new TextDocument(name.Value.ToString());

            foreach (var atrrib in attributesSplit)
            {
                newDoc.LoadProperty(atrrib.Key, atrrib.Value.ToString());
            }

            allDocuments.Add(newDoc);

            Console.WriteLine("Document added: {0}", name.Value);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }

    }

    private static List<KeyValuePair<string, object>> ParseAttributes(string[] attributes)
    {
        List<KeyValuePair<string, object>> attributesSplit = new List<KeyValuePair<string, object>>();
        foreach (var attrib in attributes)
        {
            string key = attrib.Split('=')[0];
            string value = attrib.Split('=')[1];
            attributesSplit.Add(new KeyValuePair<string, object>(key, value));
        }
        return attributesSplit;
    }

    private static void AddPdfDocument(string[] attributes)
    {
        List<KeyValuePair<string, object>> attributesSplit = ParseAttributes(attributes);

        var name = attributesSplit.Find(x => x.Key == "name");
        if (name.Key != null)
        {
            Document newDoc = new PDFDocument(name.Value.ToString());

            foreach (var atrrib in attributesSplit)
            {
                newDoc.LoadProperty(atrrib.Key, atrrib.Value.ToString());
            }

            allDocuments.Add(newDoc);

            Console.WriteLine("Document added: {0}", name.Value);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void AddWordDocument(string[] attributes)
    {
        List<KeyValuePair<string, object>> attributesSplit = ParseAttributes(attributes);

        var name = attributesSplit.Find(x => x.Key == "name");
        if (name.Key != null)
        {
            Document newDoc = new WordDocument(name.Value.ToString());

            foreach (var atrrib in attributesSplit)
            {
                newDoc.LoadProperty(atrrib.Key, atrrib.Value.ToString());
            }

            allDocuments.Add(newDoc);

            Console.WriteLine("Document added: {0}", name.Value);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void AddExcelDocument(string[] attributes)
    {
        List<KeyValuePair<string, object>> attributesSplit = ParseAttributes(attributes);

        var name = attributesSplit.Find(x => x.Key == "name");
        if (name.Key != null)
        {
            Document newDoc = new ExcelDocument(name.Value.ToString());

            foreach (var atrrib in attributesSplit)
            {
                newDoc.LoadProperty(atrrib.Key, atrrib.Value.ToString());
            }

            allDocuments.Add(newDoc);

            Console.WriteLine("Document added: {0}", name.Value);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void AddAudioDocument(string[] attributes)
    {
        List<KeyValuePair<string, object>> attributesSplit = ParseAttributes(attributes);

        var name = attributesSplit.Find(x => x.Key == "name");
        if (name.Key != null)
        {
            Document newDoc = new AudioDocument(name.Value.ToString());

            foreach (var atrrib in attributesSplit)
            {
                newDoc.LoadProperty(atrrib.Key, atrrib.Value.ToString());
            }

            allDocuments.Add(newDoc);

            Console.WriteLine("Document added: {0}", name.Value);
        }
        else
        {
            Console.WriteLine("Document has no name");
        }
    }

    private static void AddVideoDocument(string[] attributes)
    {
        List<KeyValuePair<string, object>> attributesSplit = ParseAttributes(attributes);

        var name = attributesSplit.Find(x => x.Key == "name");
        if (name.Key != null)
        {
            Document newDoc = new VideoDocument(name.Value.ToString());

            foreach (var atrrib in attributesSplit)
            {
                newDoc.LoadProperty(atrrib.Key, atrrib.Value.ToString());
            }

            allDocuments.Add(newDoc);

            Console.WriteLine("Document added: {0}", name.Value);
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
            foreach (var doc in allDocuments)
            {
                Console.WriteLine(doc);
            }
        }
        else
        {
            Console.WriteLine("No documents found");
        }
        
        
    }

    private static void EncryptDocument(string name)
    {
        var documentsWithThatName = allDocuments.FindAll(doc => doc.Name == name);
        if (documentsWithThatName.Count > 0)
        {
            foreach (var doc in documentsWithThatName)
            {
                if (doc is IEncryptable)
                {
                    (doc as IEncryptable).Encrypt();
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
        var documentsWithThatName = allDocuments.FindAll(doc => doc.Name == name);
        if (documentsWithThatName.Count > 0)
        {
            foreach (var doc in documentsWithThatName)
            {
                if (doc is IEncryptable)
                {
                    (doc as IEncryptable).Decrypt();
                    Console.WriteLine("Document decrypted: {0}", name);
                }
                else
                {
                    Console.WriteLine("Document does not support decryption: {0}", name);
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
        var encryptableDocs = allDocuments.FindAll(doc => doc is IEncryptable);
        if (encryptableDocs.Count > 0)
        {
            foreach (var doc in encryptableDocs)
            {
                (doc as IEncryptable).Encrypt();
            }
            Console.WriteLine("All documents encrypted");
        }
        else
        {
            Console.WriteLine("No encryptable documents found");
        }
    }

    private static void ChangeContent(string name, string content)
    {
        var documentsWithThatName = allDocuments.FindAll(x => x.Name == name);
        if (documentsWithThatName.Count > 0)
        {
            foreach (var doc in documentsWithThatName)
            {
                if (doc is IEditable)
                {
                    (doc as IEditable).ChangeContent(content);
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
