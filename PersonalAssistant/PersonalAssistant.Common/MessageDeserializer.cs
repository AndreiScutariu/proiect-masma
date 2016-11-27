namespace PersonalAssistant.Common
{
    using System;

    using Newtonsoft.Json;

    public class MessageDeserializer
    {
        private readonly string _content;

        public MessageDeserializer(string content)
        {
            _content = content;
        }

        public static object GetMessageInstance(Type type, string content)
        {
            var mi = typeof(MessageDeserializer).GetMethod("Deserialize");
            var fooRef = mi.MakeGenericMethod(type);
            var instance = fooRef.Invoke(new MessageDeserializer(content), null);
            return instance;
        }

        public T Deserialize<T>()
        {
            return JsonConvert.DeserializeObject<T>(_content);
        }
    }
}