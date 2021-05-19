namespace MidTermProject
{
    public static class Globals
    {
        public static int GlobalUserId { get; private set; }
        public static void SetGlobalUserId(int userId)
        {
            GlobalUserId = userId;
        }
    }
}
