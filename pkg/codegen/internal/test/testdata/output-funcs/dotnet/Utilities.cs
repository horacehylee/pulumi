// *** WARNING: this file was generated by . ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using Pulumi;

namespace Pulumi.MadeupPackage.Codegentest
{
    static class Utilities
    {
        public static string? GetEnv(params string[] names)
        {
            foreach (var n in names)
            {
                var value = Environment.GetEnvironmentVariable(n);
                if (value != null)
                {
                    return value;
                }
            }
            return null;
        }

        static string[] trueValues = { "1", "t", "T", "true", "TRUE", "True" };
        static string[] falseValues = { "0", "f", "F", "false", "FALSE", "False" };
        public static bool? GetEnvBoolean(params string[] names)
        {
            var s = GetEnv(names);
            if (s != null)
            {
                if (Array.IndexOf(trueValues, s) != -1)
                {
                    return true;
                }
                if (Array.IndexOf(falseValues, s) != -1)
                {
                    return false;
                }
            }
            return null;
        }

        public static int? GetEnvInt32(params string[] names) => int.TryParse(GetEnv(names), out int v) ? (int?)v : null;

        public static double? GetEnvDouble(params string[] names) => double.TryParse(GetEnv(names), out double v) ? (double?)v : null;

        public static InvokeOptions WithVersion(this InvokeOptions? options)
        {
            if (options?.Version != null)
            {
                return options;
            }
            return new InvokeOptions
            {
                Parent = options?.Parent,
                Provider = options?.Provider,
                Version = Version,
            };
        }

        public static Input<Dictionary<string,T>> ToDict<T>(this InputMap<T> inputList)
        {
            return inputList.Apply(v => new Dictionary<string,T>(v));
        }

        public static List<T> ToList<T>(this IEnumerable<T> elements)
        {
            return new List<T>(elements);
        }

        public static Input<List<T>> ToList<T>(this InputList<T> inputList)
        {
            return inputList.Apply(v => v.ToList());
        }

        public class Boxed
        {
            [AllowNull]
            public Object Value { get; }

            public Boxed([AllowNull] Object value)
            {
                Value = value;
            }

            public void Set(Object target, string propertyName)
            {
                var v = this.Value;
                if (v != null)
                {
                    var p = target.GetType().GetProperty(propertyName);
                    if (p != null)
                    {
                        p.SetValue(target, v);
                    }
                }
            }
        }

        public static Output<Boxed> Box<T>([AllowNull] this Input<T> input)
        {
            if (input == null)
            {
                return Output.Create(new Boxed(null));
            }
            else
            {
                return input.Apply(v => new Boxed(v));
            }
        }

        private readonly static string version;
        public static string Version => version;

        static Utilities()
        {
            var assembly = typeof(Utilities).GetTypeInfo().Assembly;
            var avail = string.Join("; ", assembly.GetManifestResourceNames());
            using var stream = assembly.GetManifestResourceStream("Pulumi.MadeupPackage.Codegentest.version.txt");
            using var reader = new StreamReader(stream ?? throw new NotSupportedException("Missing embedded version.txt file        " + avail));
            version = reader.ReadToEnd().Trim();
            var parts = version.Split("\n");
            if (parts.Length == 2)
            {
                // The first part is the provider name.
                version = parts[1].Trim();
            }
        }
    }

    internal sealed class ResourceTypeAttribute : Pulumi.ResourceTypeAttribute
    {
        public ResourceTypeAttribute(string type) : base(type, Utilities.Version)
        {
        }
    }
}
