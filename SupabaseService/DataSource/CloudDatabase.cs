namespace SupabaseService.DataSource;

public class CloudDatabase
{
    public Supabase.Client SupabaseClient { get; set; }
    public CloudDatabase(string url, string key)
    {
        SupabaseClient = new Supabase.Client(url, key);
        SupabaseClient.InitializeAsync().GetAwaiter().GetResult();
    }
}