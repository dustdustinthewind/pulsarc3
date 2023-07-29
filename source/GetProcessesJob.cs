// GetProcessesJob
using System;
using System.Collections.Generic;
using System.Diagnostics;

public class GetProcessesJob : ThreadedJob
{
	public List<string> activeProcesses;

	protected override void ECMEIIOGOLC()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "GameScene";
			processStartInfo.Arguments = "Up";
			processStartInfo.Verb = "BitsData";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("editor.");
		}
	}

	protected override void CFPEGNHBKLK()
	{
	}

	protected override void DNKDEPBOLKD()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "_SizeY";
			processStartInfo.Arguments = "_ScreenResolution";
			processStartInfo.Verb = "Objects in List: ";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("CameraFilterPack/Sharpen_Sharpen");
		}
	}

	protected override void OAKBHENIEDD()
	{
	}

	protected override void PDDDPNPFCFP()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "_Amount";
			processStartInfo.Arguments = "SpectateButton";
			processStartInfo.Verb = " base map(s)";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("settings.enablerankingnotifications");
		}
	}

	protected override void FNCACIILJFI()
	{
	}

	protected override void EJNPMGJDGLJ()
	{
	}

	protected override void NHJPFGGNEML()
	{
	}

	protected override void EDCFDDENFFG()
	{
	}

	protected override void NFIHFJLOFBJ()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = " ";
			processStartInfo.Arguments = "_Green_R";
			processStartInfo.Verb = "Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_DiffuseColor");
		}
	}

	protected override void DMBLJKLDDEA()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "] to be droppable";
			processStartInfo.Arguments = "OK";
			processStartInfo.Verb = "Keypad ";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("finished");
		}
	}

	protected override void GLBPEENJFIF()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "_ScreenResolution";
			processStartInfo.Arguments = "CameraFilterPack/Blend2Camera_Saturation";
			processStartInfo.Verb = "Left";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("CameraFilterPack/Oculus_NightVision1");
		}
	}

	protected override void HFEPBABPKJF()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "Gameplay/satellite";
			processStartInfo.Arguments = "_Value1";
			processStartInfo.Verb = "_Near";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("DPADVER");
		}
	}

	protected override void FPBNBIOODID()
	{
	}

	protected override void HAMNIIONCAH()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "editor.";
			processStartInfo.Arguments = "player.rgb";
			processStartInfo.Verb = "_ToPrevViewProjCombined";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_ScreenResolution");
		}
	}

	protected override void MNOCACNOIPB()
	{
	}

	protected override void PJKAHCHLPDF()
	{
	}

	protected override void DFJHEJCCJGI()
	{
	}

	protected override void CGMJODOBINA()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "workshop.";
			processStartInfo.Arguments = "ns";
			processStartInfo.Verb = "[LevelEditorScene] Map submitted!";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("player.deleted");
		}
	}

	protected override void BOACMLIHMGP()
	{
	}

	protected override void MJCHGGIJPOA()
	{
	}

	protected override void BOMDNIJDLNI()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "path";
			processStartInfo.Arguments = "Object ID. Case-Sensitive";
			processStartInfo.Verb = "_MainTex2";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("<scene_name> or <id>");
		}
	}

	protected override void FEFJPHMFONF()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "CameraFilterPack/Gradients_Hue";
			processStartInfo.Arguments = "settings.selectormapsperpage";
			processStartInfo.Verb = "GlassColor";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("CameraFilterPack/TV_WideScreenHV");
		}
	}

	protected override void MIBAKHAGDOP()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "_Parameter";
			processStartInfo.Arguments = "CameraFilterPack/EyesVision_2";
			processStartInfo.Verb = "SfxVolumeSlider";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("note.1");
		}
	}

	protected override void DINCOHFJLGB()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "Tab1Content";
			processStartInfo.Arguments = "Hex value #RRGGBB";
			processStartInfo.Verb = "UseScanLineSize";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("maps.");
		}
	}

	protected override void PLCDOOJMBHN()
	{
	}

	protected override void ACEJNNKPPGI()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "_Value3";
			processStartInfo.Arguments = "_TimeX";
			processStartInfo.Verb = "_RampOffset";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("turn");
		}
	}

	protected override void HCIEKDOFLJG()
	{
	}

	protected override void HDGHJPAJIEP()
	{
	}

	protected override void FMJPOOIHADM()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "In Maps Editor";
			processStartInfo.Arguments = "Encryption wasn't established: ";
			processStartInfo.Verb = " is muted";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("pointBuffer");
		}
	}

	protected override void BBMFOMHPGHH()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "CameraFilterPack_TV_BrokenGlass1";
			processStartInfo.Arguments = "PlayMapGoal";
			processStartInfo.Verb = "SetSunColors";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_VignettingDirt");
		}
	}

	protected override void MBPJCAPNFCC()
	{
	}

	protected override void KENFGMGMKJI()
	{
	}

	protected override void APCDEEPLJKO()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "_Value2";
			processStartInfo.Arguments = "CheckpointsScoreText";
			processStartInfo.Verb = ". ActorNr: ";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_NoiseTex");
		}
	}

	protected override void POFNAKKEPIJ()
	{
	}

	protected override void EOOJHKFELKM()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "_Value2";
			processStartInfo.Arguments = "_VelTex";
			processStartInfo.Verb = "_Distortion";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_Value3");
		}
	}

	protected override void KFDLFHNPAHJ()
	{
	}

	protected override void EAEAHCKIDCP()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "LastHighScoreText";
			processStartInfo.Arguments = "_Near";
			processStartInfo.Verb = "CameraFilterPack/Blend2Camera_Screen";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_Value");
		}
	}

	protected override void AENBIDPBKHL()
	{
	}

	protected override void LPALPMFBKGJ()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "checkpoint";
			processStartInfo.Arguments = "/";
			processStartInfo.Verb = "<start_index> <end_index>";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_Value");
		}
	}

	protected override void NEIPAKEGJHH()
	{
	}

	protected override void BLHMPFCIAJC()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "setbool";
			processStartInfo.Arguments = "SaveButton";
			processStartInfo.Verb = "_Value";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_Green_G");
		}
	}

	protected override void GODPOOJFKEF()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "SUBMIT '{0}' FILES";
			processStartInfo.Arguments = "ViewMenu";
			processStartInfo.Verb = "icon";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("OpenButton");
		}
	}

	protected override void JIMJIGDBGDD()
	{
	}

	protected override void POJFJEGCBAI()
	{
	}

	protected override void GIEKJDNBKMO()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "_Red_C";
			processStartInfo.Arguments = "OxOD.lastPath";
			processStartInfo.Verb = "CameraFilterPack/Blend2Camera_ColorBurn";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("Joystick");
		}
	}

	protected override void BMHFEIHGELF()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "Horizontal";
			processStartInfo.Arguments = "https://twitch.tv/intralism";
			processStartInfo.Verb = "_Value2";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_Red_C");
		}
	}

	protected override void ELMFKPOLGIP()
	{
	}

	protected override void GIDCKKBNMBM()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "maps.";
			processStartInfo.Arguments = "offsets";
			processStartInfo.Verb = "#ok";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_SceneFogMode");
		}
	}

	protected override void NHABLACAJKN()
	{
	}

	protected override void HNBCBALPKON()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "Ignored PU RPC, cause item is inactive. ";
			processStartInfo.Arguments = "#yes";
			processStartInfo.Verb = "_HalfResolution";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("[PlayerController] ");
		}
	}

	protected override void POFIKBNAKFI()
	{
	}

	protected override void GJDFLBJHLCI()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "menu.enableselectormusic";
			processStartInfo.Arguments = "[UI] ";
			processStartInfo.Verb = "Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("mapselector.filter.favoriteonly");
		}
	}

	protected override void KIECFLDLDMB()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "_Sat";
			processStartInfo.Arguments = "_Val";
			processStartInfo.Verb = "Tab1Content";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_Value");
		}
	}

	protected override void EGDBOOCKOKO()
	{
	}

	protected override void HPLJIIGDDKG()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "CameraFilterPack/Blend2Camera_Multiply";
			processStartInfo.Arguments = "EndlessLoopsScoreText";
			processStartInfo.Verb = "SetLives";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("clear");
		}
	}

	protected override void DNNGILMNLHN()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "IntraTime";
			processStartInfo.Arguments = "help";
			processStartInfo.Verb = "Joystick1Button1";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_dec.json");
		}
	}

	protected override void JHDOPBNOHGD()
	{
	}

	protected override void NNBOMFEHECG()
	{
	}

	protected override void IDHCIKEAODF()
	{
	}

	protected override void OLDLHPCAFEO()
	{
	}

	protected override void BPCFGDODIJH()
	{
	}

	protected override void LGCPLKEONJM()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "_Speed";
			processStartInfo.Arguments = "_ScreenResolution";
			processStartInfo.Verb = ".completed";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("position");
		}
	}

	protected override void OFFANFJALMA()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "_EmissionGain";
			processStartInfo.Arguments = "#news";
			processStartInfo.Verb = "_TimeX";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add(".png");
		}
	}

	protected override void LLCOADBOHGA()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "_Value2";
			processStartInfo.Arguments = "_Offsets";
			processStartInfo.Verb = "_Value7";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("settings.volume.editor");
		}
	}

	protected override void JLAPONBAOHB()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "_Value4";
			processStartInfo.Arguments = "challenges";
			processStartInfo.Verb = "_Value7";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_ScreenResolution");
		}
	}

	protected override void GFGAPJLFMGL()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "#news";
			processStartInfo.Arguments = "curScn";
			processStartInfo.Verb = "MenuScene";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_TimeX");
		}
	}

	protected override void JAFCCBIPELN()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.Arguments = "/C tasklist";
			processStartInfo.Verb = "runas";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("Error0");
		}
	}

	protected override void LFMLPCOONKN()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "/icon";
			processStartInfo.Arguments = "ResourceFileSelector";
			processStartInfo.Verb = "GLITCH";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("Object ID. Case-Sensitive");
		}
	}

	protected override void GHPPKPKAPMG()
	{
	}

	protected override void OANIGEHKJFE()
	{
	}

	protected override void BLFNOPKJDGC()
	{
	}

	protected override void MGKJJNFKBFO()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "Tab1Content";
			processStartInfo.Arguments = "_Value2";
			processStartInfo.Verb = "NetworkCanvas";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("SetSunSensitivity");
		}
	}

	protected override void NNMMPCGIFHK()
	{
	}

	protected override void PILGEDLKNEM()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "Edited unlock conditions";
			processStartInfo.Arguments = "_Value3";
			processStartInfo.Verb = " By: ";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("RedoButton");
		}
	}

	protected override void INOAGLEGOIK()
	{
	}

	protected override void PLLAFFJPFGK()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "skin.hit_wrong";
			processStartInfo.Arguments = "score:";
			processStartInfo.Verb = "_FadeShield";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("GameVolumeSlider");
		}
	}

	protected override void FGMMNICIPCH()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "Hidden/DepthOfField/BokehSplatting";
			processStartInfo.Arguments = "move";
			processStartInfo.Verb = "RanksButton";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add(" not exist");
		}
	}

	protected override void LNMBIKNNKKG()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "1 Kb";
			processStartInfo.Arguments = "_Intensity";
			processStartInfo.Verb = "open";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("float,0");
		}
	}

	protected override void IHCBHMKFDMK()
	{
	}

	protected override void CAPAEFDDBKA()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "[LevelEditorScene] Item creation successful! Published Item ID: ";
			processStartInfo.Arguments = "CameraFilterPack/Oculus_NightVision3";
			processStartInfo.Verb = "player.blackwhite";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("[DiscordController] Shutdown");
		}
	}

	protected override void CPJDOKECGFM()
	{
	}

	protected override void IMGOKKAJCDN()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "_TimeX";
			processStartInfo.Arguments = "Joystick1Button6";
			processStartInfo.Verb = "Traffic Stats";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("EditMenu");
		}
	}

	protected override void HOAJKHOOEJI()
	{
	}

	protected override void POCACGNNLPH()
	{
	}

	protected override void CNMMINLAPIF()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = "error";
			processStartInfo.Arguments = "_MainTex";
			processStartInfo.Verb = "#";
			processStartInfo.RedirectStandardOutput = false;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_Blue_B");
		}
	}

	protected override void PGDPJOJHNFH()
	{
	}

	protected override void AOKHFOKHLFB()
	{
	}

	protected override void MNDCHDKHCNI()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "SetSatelliteRotationSpeed";
			processStartInfo.Arguments = "OnAwakeRPC";
			processStartInfo.Verb = "GlassAberration";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add(".lastCheckpoint.playerdistance");
		}
	}

	protected override void NNHFKEEDJML()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "_Distortion";
			processStartInfo.Arguments = "null";
			processStartInfo.Verb = "\n";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = true;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 1)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("CameraFilterPack/Blend2Camera_VividLight");
		}
	}

	protected override void FIGEDBOOGFK()
	{
	}

	protected override void EDHDBELBMKO()
	{
	}

	protected override void EKDDMHLDHIL()
	{
	}

	protected override void GCCKMJPJLOD()
	{
		activeProcesses = new List<string>();
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.FileName = " in SaveLoadMenu.prefabDictionary!";
			processStartInfo.Arguments = "_Value4";
			processStartInfo.Verb = "setint";
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = false;
			process.StartInfo = processStartInfo;
			process.Start();
			while (!process.HasExited)
			{
				while (process.StandardOutput.Peek() >= 0)
				{
					activeProcesses.Add(process.StandardOutput.ReadLine());
				}
			}
		}
		catch (Exception)
		{
			activeProcesses.Add("_ScreenResolution");
		}
	}
}
