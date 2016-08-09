using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.SignalR;
using System.Web;
using FreeTime.Common.Services;

namespace FreeTime.WebApp.Hubs
{
    public class VotingHub : Hub
    {
        private IVotingService _votingService = new VotingService();

        public void SendVote(string vote, int topicId, string connId)
        {
            string message = _votingService.CheckVote(vote, topicId);

            if (message == "")
            {
                Clients.All.BroadcastVoted(vote, topicId);
            }

            Clients.Client(connId).SendVoteResult(topicId, message);
        }
    }
}