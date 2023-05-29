using Newtonsoft.Json;

namespace OsuNet.Converters {
	public class OsuBoolConverter : JsonConverter<bool> {
		public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer) {
			writer.WriteValue(value.ToString());
		}

		public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer) {
			return reader.Value == "1";
		}
	}
}
