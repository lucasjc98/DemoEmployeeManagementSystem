﻿using System.Text.Json;

namespace DEMS.AppLibrary.Helpers
{
    public static class Serializations
    {
        public static string SerializeObject<T>(T modelObject) => JsonSerializer.Serialize(modelObject);
        public static T DeserializeJsonString<T>(string jsonString) => JsonSerializer.Deserialize<T>(jsonString);
        public static IList<T> DeserializeJsonStringList<T>(string jsonString) => JsonSerializer.Deserialize<IList<T>>(jsonString);
    }
}
