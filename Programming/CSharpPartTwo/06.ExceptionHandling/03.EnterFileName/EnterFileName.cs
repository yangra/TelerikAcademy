﻿using System;
using System.IO;
using System.Security;

class EnterFileName
{
    static void Main()
    {
        try
        {
            string path = File.ReadAllText(@"C:\WINDOWS\win.ini");
            Console.WriteLine(path);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The path cannot be null!");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Path contains invalid characters.");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The provided path exceeds maximum allowed length.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified directory could not be found!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The specified file could not be found");
        }
        catch (IOException)
        {
            Console.WriteLine("There was an I/O error.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have the permissions to open this file.");
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine("This operation is not supported on the current platform.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("You don't have the permissions to open this file.");
        }
    }
}

