namespace BatchImageProcessor.Types
{
	public class OutputOptions
	{
		public string OutputPath { get; set; } = string.Empty;
		public string OutputTemplate { get; set; } = string.Empty;
		public NameType NameOption { get; set; } = NameType.Original;
		public double JpegQuality { get; set; } = 0.95;
		public Format OutputFormat { get; set; } = Format.Jpg;
	}
}