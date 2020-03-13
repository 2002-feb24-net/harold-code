using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> data = GetInitialData();

            string json = ConvertToJson(data);

            string filepath = "../../../data.json";

            if (!File.Exists(filepath))
            {
                data = GetInitialData();

                json = ConvertToJson(data);

                WriteToFile(json, filepath);
            }
            else
            {
                // file does exist so can read

                // read JSON from the file and deserialize it
                string fileData = ReadFromFileAsync(filepath);
                List<Person> deserializedList = DeSerialize(fileData);
                ModifyPersons(deserializedList);
                string json2 = ConvertToJson(deserializedList);

                WriteToFile(json2, filepath);

            }




        }

        static List<Person> GetInitialData()
        {
            var list = new List<Person>();
            var person1 = new Person();
            person1.Id = 1;
            person1.Name = "Nick";

            var person2 = new Person();
            person2.Id = 2;
            person2.Name = "Mark";
            person2.Children = new List<Person>
            {
                new Person { Id = 3, Name = "Ethan" },
                new Person { Id = 4, Name = "Hope"}

            };

            list.Add(person1);
            list.Add(person2);
            return list;


        }

        static string ConvertToJson(List<Person> data)
        {
            return JsonSerializer.Serialize(data); // default behavior
                                                   // can use other methods to change settings
        }

        private static void ModifyPersons(List<Person> data)
        {
            foreach (var person in data)
            {
                person.Id++;
            }
        }


        private async static Task WriteToFile(string text, string path)
        {
            FileStream file = null;
            try
            {
                file = new FileStream(path, FileMode.Create);
                // convert the string into an array of binary data (in UTF-8 encoding)
                byte[] data = Encoding.UTF8.GetBytes(text);

                await file.WriteAsync(data);
            }
            //catch
            //{
            //   // we can catch ANY exception... this is bad practice
            //}
            catch (UnauthorizedAccessException ex)
            {
                // useful properties of the exception:
                // Message, StackTrace, InnerException
                Console.WriteLine($"Access to file {path} is not allowed by the OS:");
                Console.WriteLine(ex.Message);
                throw; // rethrows the exception to be caught again higher up the call stack.
            }
            finally
            {
                if (file != null)
                {
                    //file.Close();
                    file.Dispose();
                }
            }
        }

        private async static Task<string> ReadFromFileAsync(string filepath)
        {
            // Task<string> readTextTask = await File.ReadAllText(filepath);
            using var sr = new StreamReader(filepath);
            Task<string> readTextTask =  sr.ReadToEndAsync();
            return await readTextTask;

        }


        private static List<Person> DeSerialize(string text)
        {
            var data = JsonSerializer.Deserialize<List<Person>>(text);
            return data;
        }


    }
}
