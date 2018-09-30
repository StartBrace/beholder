namespace StartBrace.Beholder.Common
{
    public static class BeholderConstants
    {
        public static string CodeName => "Beholder";

        public static int MajorVersion => 0;
        public static int MinorVersion => 1;
        public static int PatchVersion => 0;
        public static int BuildVersion => 0;

        public static string Version => $"{MajorVersion}.{MinorVersion}.{PatchVersion}.{BuildVersion}";
        public static string ReleaseName => $"{CodeName}.{Version}";
    }
}