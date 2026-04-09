namespace knightmoves;
using static StateList;
using System.Linq;

public class StateLookUp {
    public IEnumerable<string> LookUp(string search) {
        return from state in STATES
               where state.StartsWith(search)
               select state;
    }
}
