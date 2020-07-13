namespace Antlr4.Runtime
{
    /**
 * Simple builder class for TokenChange
 */
    public class TokenChangeBuilder {
        private TokenChangeType changeType;
        private CommonToken oldToken;
        private CommonToken newToken;

        public TokenChangeBuilder setChangeType(TokenChangeType changeType) {
            this.changeType = changeType;
            return this;
        }

        public TokenChangeBuilder setOldToken(CommonToken oldToken) {
            this.oldToken = oldToken;
            return this;
        }

        public TokenChangeBuilder setNewToken(CommonToken newToken) {
            this.newToken = newToken;
            return this;
        }

        public TokenChange createTokenChange() {
            return new TokenChange(changeType, oldToken, newToken);
        }
    }
}