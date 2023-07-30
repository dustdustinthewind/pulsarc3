// BuildConstants
using System;

public static class BuildConstants
{
	public enum ReleaseType
	{
		None,
		Debug,
		Release
	}

	public enum Platform
	{
		None,
		Linux,
		OSX,
		PC
	}

	public enum Architecture
	{
		None,
		Linux_Universal,
		OSX_Universal,
		Windows_x86,
		Windows_x64
	}

	public enum Distribution
	{
		None
	}

	public static readonly DateTime buildDate = new DateTime(637172875801193637L);

	public const string version = "5.5.0.3492";

	public const ReleaseType releaseType = ReleaseType.Release;

	public const Platform platform = Platform.PC;

	public const Architecture architecture = Architecture.Windows_x64;

	public const Distribution distribution = Distribution.None;
}
