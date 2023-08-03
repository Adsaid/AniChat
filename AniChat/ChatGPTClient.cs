using MySql.Data.MySqlClient.Memcached;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniChat
{
    internal class ChatGPTClient
    {

        private readonly string _apiKey;
        private readonly RestClient _client;

        // Constructor that takes the API key as a parameter
        public ChatGPTClient(string apiKey)
        {
            _apiKey = apiKey;
            // Initialize the RestClient with the ChatGPT API endpoint
            _client = new RestClient("https://api.openai.com/v1/engines/text-davinci-003/completions");
        }

        // Method to send a message to the ChatGPT API and return the response
        public string SendMessage(string message)
        {
            try
            {
                // Create a new POST request
                var request = new RestRequest("", Method.Post);
                // Set the Content-Type header
                request.AddHeader("Content-Type", "application/json");
                // Set the Authorization header with the API key
                request.AddHeader("Authorization", $"Bearer {_apiKey}");

                // Create the request body with the message and other parameters
                var requestBody = new
                {
                    prompt = message,
                    max_tokens = 500,
                    n = 1,
                    stop = (string)null,
                    temperature = 0.7,
                };

                // Add the JSON body to the request
                request.AddJsonBody(JsonConvert.SerializeObject(requestBody));

                // Execute the request and receive the response
                var response = _client.Execute(request);

                // Deserialize the response JSON content
                var jsonResponse = JsonConvert.DeserializeObject<dynamic>(response.Content ?? string.Empty);

                // Extract and return the chatbot's response text
                return jsonResponse?.choices[0]?.text?.ToString()?.Trim() ?? string.Empty;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the API request
                return $"Error: {ex.Message}\n Sorry, there was an error processing your request. Please try again later.";
            }

        }
    }
}
