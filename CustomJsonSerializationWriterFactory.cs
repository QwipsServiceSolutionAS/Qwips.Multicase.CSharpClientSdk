﻿using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Xml;

namespace Qwips.Core.MultiCase
{
    /// <summary>
    /// Write json, include null values
    /// </summary>
    public class CustomJsonSerializationWriterFactory : ISerializationWriterFactory
    {

        /// <summary>
        /// The valid content type for json
        /// </summary>
        public string ValidContentType { get; } = "application/json";

        /// <summary>
        /// Get a valid <see cref="ISerializationWriter"/> for the content type
        /// </summary>
        /// <param name="contentType">The content type to search for</param>
        /// <returns>A <see cref="ISerializationWriter"/> instance for json writing</returns>
        public ISerializationWriter GetSerializationWriter(string contentType)
        {
            if (string.IsNullOrEmpty(contentType))
                throw new ArgumentNullException(nameof(contentType));
            else if (!ValidContentType.Equals(contentType, StringComparison.OrdinalIgnoreCase))
                throw new ArgumentOutOfRangeException($"expected a {ValidContentType} content type");
            var ret = new CustomJsonSerializationWriter();
            return ret;
        }

    }

    /// <summary>
    /// The <see cref="ISerializationWriter"/> implementation for json content types.
    /// </summary>
    public class CustomJsonSerializationWriter : ISerializationWriter, IDisposable
    {
        public bool WriteNull { get; set; } = true;
        private readonly MemoryStream _stream = new MemoryStream();

        /// <summary>
        /// The <see cref="Utf8JsonWriter"/> instance for writing json content
        /// </summary>
        public readonly Utf8JsonWriter writer;

        /// <summary>
        /// The <see cref="JsonSerializationWriter"/> constructor
        /// </summary>
        public CustomJsonSerializationWriter()
        {
            writer = new Utf8JsonWriter(_stream);
        }

        /// <summary>
        /// The action to perform before object serialization
        /// </summary>
        public Action<IParsable> OnBeforeObjectSerialization { get; set; }

        /// <summary>
        /// The action to perform after object serialization
        /// </summary>
        public Action<IParsable> OnAfterObjectSerialization { get; set; }

        /// <summary>
        /// The action to perform on the start of object serialization
        /// </summary>
        public Action<IParsable, ISerializationWriter> OnStartObjectSerialization { get; set; }

        /// <summary>
        /// Get the stream of the serialized content
        /// </summary>
        /// <returns>The <see cref="Stream"/> of the serialized content</returns>
        public Stream GetSerializedContent()
        {
            writer.Flush();
            _stream.Position = 0;
            return _stream;
        }

        /// <summary>
        /// Write the string value
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The string value</param>
        public void WriteStringValue(string key, string value)
        {
            if (value != null)
            { // we want to keep empty string because they are meaningful
                if (!string.IsNullOrEmpty(key)) writer.WritePropertyName(key);
                writer.WriteStringValue(value);
            }
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the boolean value
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The boolean value</param>
        public void WriteBoolValue(string key, bool? value)
        {
            if (!string.IsNullOrEmpty(key) && value.HasValue) writer.WritePropertyName(key);
            if (value.HasValue) writer.WriteBooleanValue(value.Value);
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the byte value
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The byte value</param>
        public void WriteByteValue(string key, byte? value)
        {
            if (!string.IsNullOrEmpty(key) && value.HasValue) writer.WritePropertyName(key);
            if (value.HasValue) writer.WriteNumberValue(Convert.ToInt32(value.Value));
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the sbyte value
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The sbyte value</param>
        public void WriteSbyteValue(string key, sbyte? value)
        {
            if (!string.IsNullOrEmpty(key) && value.HasValue) writer.WritePropertyName(key);
            if (value.HasValue) writer.WriteNumberValue(Convert.ToInt32(value.Value));
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the int value
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The int value</param>
        public void WriteIntValue(string key, int? value)
        {
            if (!string.IsNullOrEmpty(key) && value.HasValue) writer.WritePropertyName(key);
            if (value.HasValue) writer.WriteNumberValue(value.Value);
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the float value
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The float value</param>
        public void WriteFloatValue(string key, float? value)
        {
            if (!string.IsNullOrEmpty(key) && value.HasValue) writer.WritePropertyName(key);
            if (value.HasValue) writer.WriteNumberValue(value.Value);
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the long value
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The long value</param>
        public void WriteLongValue(string key, long? value)
        {
            if (!string.IsNullOrEmpty(key) && value.HasValue) writer.WritePropertyName(key);
            if (value.HasValue) writer.WriteNumberValue(value.Value);
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the double value
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The double value</param>
        public void WriteDoubleValue(string key, double? value)
        {
            if (!string.IsNullOrEmpty(key) && value.HasValue) writer.WritePropertyName(key);
            if (value.HasValue) writer.WriteNumberValue(value.Value);
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the decimal value
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The decimal value</param>
        public void WriteDecimalValue(string key, decimal? value)
        {
            if (!string.IsNullOrEmpty(key) && value.HasValue) writer.WritePropertyName(key);
            if (value.HasValue) writer.WriteNumberValue(value.Value);
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the Guid value
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The Guid value</param>
        public void WriteGuidValue(string key, Guid? value)
        {
            if (!string.IsNullOrEmpty(key) && value.HasValue) writer.WritePropertyName(key);
            if (value.HasValue) writer.WriteStringValue(value.Value);
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the DateTimeOffset value
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The DateTimeOffset value</param>
        public void WriteDateTimeOffsetValue(string key, DateTimeOffset? value)
        {
            if (!string.IsNullOrEmpty(key) && value.HasValue) writer.WritePropertyName(key);
            if (value.HasValue) writer.WriteStringValue(value.Value);
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the TimeSpan(An ISO8601 duration.For example, PT1M is "period time of 1 minute") value.
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The TimeSpan value</param>
        public void WriteTimeSpanValue(string key, TimeSpan? value)
        {
            if (!string.IsNullOrEmpty(key) && value.HasValue) writer.WritePropertyName(key);
            if (value.HasValue) writer.WriteStringValue(XmlConvert.ToString(value.Value));
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the Date value
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The Date value</param>
        public void WriteDateValue(string key, Date? value)
        {
            if (!string.IsNullOrEmpty(key) && value.HasValue) writer.WritePropertyName(key);
            if (value.HasValue) writer.WriteStringValue(value.Value.ToString());
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the Time value
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The Time value</param>
        public void WriteTimeValue(string key, Time? value)
        {
            if (!string.IsNullOrEmpty(key) && value.HasValue) writer.WritePropertyName(key);
            if (value.HasValue) writer.WriteStringValue(value.Value.ToString());
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the null value
        /// </summary>
        /// <param name="key">The key of the json node</param>
        public void WriteNullValue(string key)
        {
            if (!string.IsNullOrEmpty(key)) writer.WritePropertyName(key);
            writer.WriteNullValue();
        }

        /// <summary>
        /// Write the enumeration value of type  <typeparam name="T"/>
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The enumeration value</param>
        public void WriteEnumValue<T>(string key, T? value) where T : struct, Enum
        {
            if (!string.IsNullOrEmpty(key) && value.HasValue) writer.WritePropertyName(key);
            if (value.HasValue)
            {
                if (typeof(T).GetCustomAttributes<FlagsAttribute>().Any())
                    writer.WriteStringValue(Enum.GetValues(typeof(T))
                                            .Cast<T>()
                                            .Where(x => value.Value.HasFlag(x))
                                            .Select(GetEnumName)
                                            .Aggregate((x, y) => $"{x},{y}"));
                else writer.WriteStringValue(GetEnumName(value.Value));
            }
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the collection of primitives of type  <typeparam name="T"/>
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="values">The primitive collection</param>
        public void WriteCollectionOfPrimitiveValues<T>(string key, IEnumerable<T> values)
        {
            if (values != null)
            { //empty array is meaningful
                if (!string.IsNullOrEmpty(key)) writer.WritePropertyName(key);
                writer.WriteStartArray();
                foreach (var collectionValue in values)
                    WriteAnyValue(null, collectionValue);
                writer.WriteEndArray();
            }
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the collection of objects of type  <typeparam name="T"/>
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="values">The object collection</param>
        public void WriteCollectionOfObjectValues<T>(string key, IEnumerable<T> values) where T : IParsable
        {
            if (values != null)
            { //empty array is meaningful
                if (!string.IsNullOrEmpty(key)) writer.WritePropertyName(key);
                writer.WriteStartArray();
                foreach (var item in values)
                    WriteObjectValue<T>(null, item);
                writer.WriteEndArray();
            }
            else if (WriteNull) WriteNullValue(key);
        }
        /// <summary>
        /// Writes the specified collection of enum values to the stream with an optional given key.
        /// </summary>
        /// <param name="key">The key to be used for the written value. May be null.</param>
        /// <param name="values">The enum values to be written.</param>
        public void WriteCollectionOfEnumValues<T>(string key, IEnumerable<T?> values) where T : struct, Enum
        {
            if (values != null)
            { //empty array is meaningful
                if (!string.IsNullOrEmpty(key)) writer.WritePropertyName(key);
                writer.WriteStartArray();
                foreach (var item in values)
                    WriteEnumValue<T>(null, item);
                writer.WriteEndArray();
            }
            else if (WriteNull) WriteNullValue(key);
        }
        /// <summary>
        /// Writes the specified byte array as a base64 string to the stream with an optional given key.
        /// </summary>
        /// <param name="key">The key to be used for the written value. May be null.</param>
        /// <param name="value">The byte array to be written.</param>
        public void WriteByteArrayValue(string key, byte[] value)
        {
            if (value != null || WriteNull == true)//empty array is meaningful
                WriteStringValue(key, value.Any() ? Convert.ToBase64String(value) : string.Empty);
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the object of type <typeparam name="T"/>
        /// </summary>
        /// <param name="key">The key of the json node</param>
        /// <param name="value">The object instance to write</param>
        /// <param name="additionalValuesToMerge">The additional values to merge to the main value when serializing an intersection wrapper.</param>
        public void WriteObjectValue<T>(string key, T value, params IParsable[] additionalValuesToMerge) where T : IParsable
        {
            if (value != null || additionalValuesToMerge.Any(x => x != null))
            {
                if (!string.IsNullOrEmpty(key)) writer.WritePropertyName(key);
                if (value != null || WriteNull == true) OnBeforeObjectSerialization?.Invoke(value);
                writer.WriteStartObject();
                if (value != null || WriteNull == true)
                {
                    OnStartObjectSerialization?.Invoke(value, this);
                    value.Serialize(this);
                }
                foreach (var additionalValueToMerge in additionalValuesToMerge.Where(x => x != null))
                {
                    OnBeforeObjectSerialization?.Invoke(additionalValueToMerge);
                    OnStartObjectSerialization?.Invoke(additionalValueToMerge, this);
                    additionalValueToMerge.Serialize(this);
                    OnAfterObjectSerialization?.Invoke(additionalValueToMerge);
                }
                writer.WriteEndObject();
                if (value != null || WriteNull == true) OnAfterObjectSerialization?.Invoke(value);
            }
            else if (WriteNull) WriteNullValue(key);
        }

        /// <summary>
        /// Write the additional data property bag
        /// </summary>
        /// <param name="value">The additional data dictionary</param>
        public void WriteAdditionalData(IDictionary<string, object> value)
        {
            if (value == null) return;

            foreach (var dataValue in value)
                WriteAnyValue(dataValue.Key, dataValue.Value);


        }

        private void WriteNonParsableObjectValue<T>(string key, T value)
        {
            if (!string.IsNullOrEmpty(key))
                writer.WritePropertyName(key);
            writer.WriteStartObject();
            if (value == null) writer.WriteNullValue();
            else
                foreach (var oProp in value.GetType().GetProperties())
                    WriteAnyValue(oProp.Name, oProp.GetValue(value));
            writer.WriteEndObject();
        }
        private void WriteAnyValue<T>(string key, T value)
        {
            switch (value)
            {
                case string s:
                    WriteStringValue(key, s);
                    break;
                case bool b:
                    WriteBoolValue(key, b);
                    break;
                case byte b:
                    WriteByteValue(key, b);
                    break;
                case sbyte b:
                    WriteSbyteValue(key, b);
                    break;
                case int i:
                    WriteIntValue(key, i);
                    break;
                case float f:
                    WriteFloatValue(key, f);
                    break;
                case long l:
                    WriteLongValue(key, l);
                    break;
                case double d:
                    WriteDoubleValue(key, d);
                    break;
                case Guid g:
                    WriteGuidValue(key, g);
                    break;
                case DateTimeOffset dto:
                    WriteDateTimeOffsetValue(key, dto);
                    break;
                case TimeSpan timeSpan:
                    WriteTimeSpanValue(key, timeSpan);
                    break;
                case IEnumerable<object> coll:
                    WriteCollectionOfPrimitiveValues(key, coll);
                    break;
                case IParsable parseable:
                    WriteObjectValue(key, parseable);
                    break;
                case Date date:
                    WriteDateValue(key, date);
                    break;
                case DateTime dateTime:
                    WriteDateTimeOffsetValue(key, new DateTimeOffset(dateTime));
                    break;
                case Time time:
                    WriteTimeValue(key, time);
                    break;
                case JsonElement jsonElement:
                    if (!string.IsNullOrEmpty(key)) writer.WritePropertyName(key);
                    jsonElement.WriteTo(writer);
                    break;
                case object o:
                    WriteNonParsableObjectValue(key, o);
                    break;
                default:
                    throw new InvalidOperationException($"error serialization additional data value with key {key}, unknown type {value?.GetType()}");
            }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            writer.Dispose();
            GC.SuppressFinalize(this);
        }

        private string GetEnumName<T>(T value) where T : struct, Enum
        {
            return value.GetType().GetEnumName(value);
        }
    }
}



