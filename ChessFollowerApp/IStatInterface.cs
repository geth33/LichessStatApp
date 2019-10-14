using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessFollowerApp
{
    public interface IStatInterface
    {
        // Signals that user has submitted new request for a rating comparison report
        event Action<string, string, string> SubmitRatingComparatorEvent;

        // Signals that user has submitted new request for a follower stat report
        event Action<string, string> SubmitFollowerStatEvent;

        // Event that says user is canceling current operation
        event Action CancelButtonHit;

        // Toggles all controls in the form to opposite of what is currently enabled
        void ToggleControls(string mode);
        
        // Method in ChessForm that sets text on Comparator page to the correct values.
        void SetupStatComparatorPage(string username, string relation, string variant, int percentage, int numUsersPlayVariant, int followerCount, int averageRating, int userRating, Link ratingLink, int lowestRating, string lowestName);
        
        // Method in ChessForm that sets text on Follower Stat page to the correct values.
        void SetupFollowerStatPage(string username, string relationship, int followerCount, Link mostActiveLinkRoot, Link mostTvLinkRoot, Link countryMap, Dictionary<int,int> ratingMap);

        // Starts a timer that helps estimate time left in gathering the data.
        void StartTimer(int timeEstimate, string operationType);
    }
}
