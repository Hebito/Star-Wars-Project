using System;
using StarWarsAPI.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StarWarsAPI
{
    public class JSONHelper
    {
        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        
        //Method to find planet information and put into planet objects
        public static async Task<Planet> GetPlanet(string IDFinder)
        {
            using (HttpClient client = new HttpClient())
            {
                Planet myDeserializedClass = new Planet();
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                try
                {
                    string ID = IDFinder;
                    HttpResponseMessage response = await client.GetAsync($"https://swapi.dev/api/planets/{ID}");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    myDeserializedClass = JsonConvert.DeserializeObject<Planet>(responseBody);

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }

                return myDeserializedClass;
            }
        }

        //Method to grab people id and put into people object
        public static async Task<People> GetPeople(string IDFinder)
        {
            using (HttpClient client = new HttpClient())
            {
                People myDeserializedClass = new People();
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                try
                {
                    string ID = IDFinder;
                    HttpResponseMessage response = await client.GetAsync($"https://swapi.dev/api/people/{ID}");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    myDeserializedClass = JsonConvert.DeserializeObject<People>(responseBody);

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }

                return myDeserializedClass;
            }
        }

        //Method to grab species id and put into species object
        public static async Task<Species> GetSpecies(string IDFinder)
        {
            using (HttpClient client = new HttpClient())
            {
                Species myDeserializedClass = new Species();
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                try
                {
                    string ID = IDFinder;
                    HttpResponseMessage response = await client.GetAsync($"https://swapi.dev/api/species/{ID}");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    myDeserializedClass = JsonConvert.DeserializeObject<Species>(responseBody);

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }

                return myDeserializedClass;
            }
        }

        //Gets the homeworld from url in a species or person's homeworld string
        public static async Task<Planet> GetHomeWorld(string HomeString)
        {
            using (HttpClient client = new HttpClient())
            {
                Planet myDeserializedClass = new Planet();
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                try
                {
                    string HS = HomeString;
                    HttpResponseMessage response = await client.GetAsync(HS);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    myDeserializedClass = JsonConvert.DeserializeObject<Planet>(responseBody);

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }

                return myDeserializedClass;  
            }
        }

        //Gets the starship url from a person's starship id
        public static async Task<Starship> GetStarShip(string StarShipString)
        {
            using (HttpClient client = new HttpClient())
            {
                Starship myDeserializedClass = new Starship();
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                try
                {
                    string SSS = StarShipString;
                    HttpResponseMessage response = await client.GetAsync(SSS);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    myDeserializedClass = JsonConvert.DeserializeObject<Starship>(responseBody);

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }

                return myDeserializedClass;
            }
        }
    }
}
