using CompuMaster.Windows.Forms.DigitalRuneTextEditor.Document;


namespace CompuMaster.Windows.Forms.DigitalRuneTextEditor.Bookmarks
{
  /// <summary>
  /// A factory object for creating bookmarks.
  /// </summary>
  public interface IBookmarkFactory
  {
    /// <summary>
    /// Creates a bookmark.
    /// </summary>
    /// <param name="document">The document.</param>
    /// <param name="location">The location of the bookmark.</param>
    /// <returns>The bookmark.</returns>
    Bookmark CreateBookmark(IDocument document, TextLocation location);
  }
}
