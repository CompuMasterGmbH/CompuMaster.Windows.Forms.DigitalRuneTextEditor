using System.Collections.Generic;
using CompuMaster.Windows.Forms.DigitalRuneTextEditor.Document;


namespace CompuMaster.Windows.Forms.DigitalRuneTextEditor.Folding
{
	/// <summary>
	/// This interface is used for the folding capabilities
	/// of a <see cref="TextArea"/>.
	/// </summary>
	public interface IFoldingStrategy
	{
    /// <summary>
    /// Generates the folds.
    /// </summary>
    /// <param name="document">The document.</param>
    /// <param name="fileName">Name of the file.</param>
    /// <param name="parseInformation">The parse information.</param>
    /// <returns>A list containing all foldings.</returns>
		List<Fold> GenerateFolds(IDocument document, string fileName, object parseInformation);
	}
}
