using System.Text;

namespace LANraragi_Plus
{
    public static class Consts
    {
        public static string SystemName { get; set; } = "LANraragi Plus";

        public static string SystemVersion { get; set; } = "1.0.0";
    }

    public class SuperString
    {
        private readonly StringBuilder stringBuilder;

        public SuperString(string s) : this(new StringBuilder())
        {
            stringBuilder.Append(s);
        }

        public SuperString(StringBuilder stringBuilder)
        {
            this.stringBuilder = stringBuilder;
        }

        public static implicit operator SuperString(string s)
        {
            return new SuperString(s);
        }

        public static implicit operator SuperString(StringBuilder s)
        {
            return new SuperString(s);
        }

        public override string ToString()
        {
            return stringBuilder.ToString();
        }

        public SuperString Append(string str)
        {
            return stringBuilder.Append(str);
        }

        public SuperString AppPath(params string[] str)
        {
            string basePath = ToString();
            foreach (string item in str)
            {
                basePath = Path.Combine(basePath, item);
            }
            stringBuilder.Clear();
            return stringBuilder.Append(basePath);
        }

        public SuperString AppendLine(string? str = null)
        {
            if (str == null)
                return stringBuilder.AppendLine();
            else
                return stringBuilder.AppendLine(str);
        }

        public FileInfo OpenAsFile()
        {
            return new FileInfo(ToString());
        }

        public List<string> OpenAsFileReadLines()
        {
            List<string> result = [];
            using (StreamReader stream = OpenAsFile().OpenText())
            {
                result.Add(stream.ReadLine() ?? string.Empty);
            }
            return result;
        }

        public void SaveAsFile(string fileName)
        {
            using (FileStream file = new(fileName, FileMode.OpenOrCreate))
            {
                file.Write(buffer: Encoding.UTF8.GetBytes(ToString()));
            }
        }

        public void SaveAsFilename(string text)
        {
            using (FileStream file = new(ToString(), FileMode.OpenOrCreate))
            {
                file.Write(buffer: Encoding.UTF8.GetBytes(text));
            }
        }
    }
}
