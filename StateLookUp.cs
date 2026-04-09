namespace knightmoves;
using static StateList;
using System.Linq;

public class StateLookUp {
    public IEnumerable<string> LookUp(string search) {
        return STATES.Where(state => state.StartsWith(search));
    }
}

