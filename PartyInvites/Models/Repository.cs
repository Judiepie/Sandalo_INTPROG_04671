namespace PartyInvites.Models
{
    public class Repository
    {
     public static List<PartyInvites> response = new List<PartyInvites>();

    public static IEnumerable<PartyInvites> Response { get { return response; } }
    
    public static void AddResponse(PartyInvites response)
        {
            Console.WriteLine(response);
            response.Add(response);
        }            
    }
}
