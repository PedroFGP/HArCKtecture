using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Linq;

namespace HArCKtecture.Classes
{
    public class DescriptionList : Attribute
    {
        public string[] Descriptions { get; set; }

        public DescriptionList(params string[] list)
        {
            Descriptions = list;
        }
    }

    public static class EnumExtensions
    {
        public static List<string> GetDescriptionsList(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            if (fieldInfo == null)
            {
                return null;
            }

            var attribute = fieldInfo.GetCustomAttribute(typeof(DescriptionList)) as DescriptionList;

            return attribute.Descriptions.ToList();
        }

        public static string GetDescription(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            if (fieldInfo == null)
            {
                return null;
            }

            var attribute = fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;

            return attribute.Description;
        }

        public static Dictionary<string, TEnum> GetDescriptionList<TEnum>()
            where TEnum : struct
        {
            return ((TEnum[])Enum.GetValues(typeof(TEnum)))
               .ToDictionary(k => ((Enum)(object)k).GetDescription(), v => v);
        }
    }
}
