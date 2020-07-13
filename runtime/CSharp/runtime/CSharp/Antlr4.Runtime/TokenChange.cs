namespace Antlr4.Runtime
{
    /**
 * Classes that represents a change to a single token
 *
 * For change type ADDED, newToken is required.
 *
 * For change type REMOVED, oldToken is required.
 *
 * For change type CHANGED, oldToken and newToken are required.
 *
 * Token changes may *not* overlap. You also need to account for hidden tokens
 * (but not *skipped* ones).
 */
    public class TokenChange {
        public TokenChangeType changeType;
        public CommonToken oldToken;
        public CommonToken newToken;
        public TokenChange(TokenChangeType changeType,CommonToken oldToken, CommonToken newToken ) {
            this.changeType = changeType;
            this.oldToken = oldToken;
            this.newToken = newToken;
        }
    }
}