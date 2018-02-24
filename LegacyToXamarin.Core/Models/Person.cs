using System;
using Newtonsoft.Json;

namespace LegacyToXamarin.Models
{
    public class Person
    {
        [JsonProperty(PropertyName = "id")] public int Id { get; set; }
        [JsonProperty(PropertyName = "name")] public string Name { get; set; }

        [JsonProperty(PropertyName = "birthday")]
        public DateTimeOffset Birthday { get; set; }

        /// <summary>
        /// ListBoxに表示される文字列
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Id}:{Name} {Birthday.Year}/{Birthday.Month}/{Birthday.Day}";
        }
    }
}