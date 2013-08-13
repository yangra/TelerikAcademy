//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores 
//it the current directory. Find in Google how to download files in C#. 
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.IO;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        using (WebClient client = new WebClient())
        {
            try
            {
                client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"..\..\Logo.jpg");
                Console.WriteLine("Successful download.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The value of address for download cannot be null!");
            }
            catch (IOException)
            {
                Console.WriteLine("There occured an I/O exception trying to read the file");
            }
            catch (WebException)
            {
                Console.WriteLine("There was a problem establishing connection to the Internet, the server or a problem while downloading occured.");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("This operation is not supported on the current platform.");
            }
            //finally
            //{
            //    ((IDisposable)client).Dispose();
            //}
        }
    }
}

