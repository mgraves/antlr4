namespace Antlr4.Runtime
{
    /**
 * Definition of a token change:
 *
 * ADDED = A new token that did not exist before
 *
 * CHANGED = A token that was in the stream before but changed in some way.
 *
 * REMOVED = A token that no longer exists in the stream.
 *
 */
    public enum TokenChangeType {
        ADDED, CHANGED, REMOVED,
    };

}