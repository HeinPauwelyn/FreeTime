namespace FreeTime.Common.Services
{
    public interface IVotingService
    {
        string CheckVote(string vote, int topicId);
    }
}