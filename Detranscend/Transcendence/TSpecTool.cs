using System.Globalization;

namespace Detranscend.Transcendence
{
    public static class TSpecTool
    {
        public static bool ToBool(this string data, bool defaultValue = false) => data == "true" ? true : data == "false" ? false : defaultValue;
        public static float ToFloat(this string data, float defaultValue = 0f) => float.TryParse(data, NumberStyles.Any, CultureInfo.InvariantCulture, out float result) ? result : defaultValue;
        public static int ToInt(this string data, int defaultValue = 0) => int.TryParse(data, NumberStyles.Any, CultureInfo.InvariantCulture, out int result) ? result : defaultValue;
        public static Unid ToUnid(this string data) => UnidManager.CreateOrGetUnidFromReference(data);
    }
}
