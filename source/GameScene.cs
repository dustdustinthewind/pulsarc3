// GameScene
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AudioVisualizer;
using CodeStage.AntiCheat.ObscuredTypes;
using ExitGames.Client.Photon;
using Newtonsoft.Json;
using Steamworks;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameScene : Scene
{
	public enum GameMode
	{
		Relax,
		Normal,
		Hardcore,
		Random,
		Endless,
		Hidden
	}

	[CompilerGenerated]
	private sealed class CLIFHDIIFCC
	{
		internal string CBOLFPGKALK;

		internal GameScene ADPIKBBAKHP;

		internal bool BNAGFAENIDL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool LGKMMLGKBEF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool FHFECFLBHMA(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.KDPDAEEFMKK())
			{
				if (ADPIKBBAKHP.gameMode != (GameMode)6)
				{
					return ADPIKBBAKHP.gameMode == GameMode.Relax;
				}
				return true;
			}
			return false;
		}

		internal bool KFGOFDPOPKH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool CJDNDHBDMMO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool BJGDNLAOMHE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool INCKLCFEMJK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool JPGFOBNOBKN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool KFNPHCCAJFD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool ECGDAHDOPBO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool PHFMMNELDEA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool PAPLALDGKCH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool HMMBBDJNGGL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool PIJAOCFAPKC(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.JAABFBDLBAK() && ADPIKBBAKHP.gameMode != GameMode.Hardcore)
			{
				return ADPIKBBAKHP.gameMode == GameMode.Relax;
			}
			return true;
		}

		internal bool LKLABDAJAEH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool NEIDGMKKCBI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool JKEDCEOCPJO(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.KDPDAEEFMKK() && ADPIKBBAKHP.gameMode != (GameMode)6)
			{
				return ADPIKBBAKHP.gameMode == GameMode.Normal;
			}
			return true;
		}

		internal bool KNBIMOPNANA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool FBGMHPEEIFC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool BJMAIJDIKCN(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.MENGIJNONGP())
			{
				if (ADPIKBBAKHP.gameMode != (GameMode)6)
				{
					return ADPIKBBAKHP.gameMode == GameMode.Relax;
				}
				return false;
			}
			return true;
		}

		internal bool JPICHJKIMDH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool ONEPCCGOEKI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool MKLOGMNMFAF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool KAGCEJDLEEP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool DGDCNDCGPCP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool IKBMJOOJBOM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool ONNKBAIAJGP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool FPHPIHOGLHK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool GDPOLEHICGE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool LHGKFAAMKFK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool PHCNGBEFDNP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial)
			{
				if (ADPIKBBAKHP.gameMode != GameMode.Hardcore)
				{
					return ADPIKBBAKHP.gameMode == GameMode.Normal;
				}
				return true;
			}
			return false;
		}

		internal bool CKLEFMLCEBN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool OFHCGKJFGDI(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.KDPDAEEFMKK())
			{
				if (ADPIKBBAKHP.gameMode != GameMode.Endless)
				{
					return ADPIKBBAKHP.gameMode == GameMode.Normal;
				}
				return false;
			}
			return true;
		}

		internal bool FDAIFOAGDLA(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.NKDHAKBLODD() && ADPIKBBAKHP.gameMode != (GameMode)8)
			{
				return ADPIKBBAKHP.gameMode == GameMode.Normal;
			}
			return false;
		}

		internal bool OPLNAAKJHAI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool EGKGJJGAPMN(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.MENGIJNONGP())
			{
				if (ADPIKBBAKHP.gameMode != (GameMode)8)
				{
					return ADPIKBBAKHP.gameMode == GameMode.Normal;
				}
				return false;
			}
			return true;
		}

		internal bool MGENGAEDACG(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.MENGIJNONGP())
			{
				if (ADPIKBBAKHP.gameMode != GameMode.Normal)
				{
					return ADPIKBBAKHP.gameMode == GameMode.Normal;
				}
				return false;
			}
			return true;
		}

		internal bool NOJCMLCPIKB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool MOJCLHBKMHF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool CILDPMKMPFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool DIOBKCECBCH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool IIMOMJLLFDB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool DBFPGFHEGKA(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.MENGIJNONGP())
			{
				if (ADPIKBBAKHP.gameMode != GameMode.Endless)
				{
					return ADPIKBBAKHP.gameMode == GameMode.Relax;
				}
				return true;
			}
			return false;
		}

		internal bool MMJGKBNKFGM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK);
		}
	}

	[CompilerGenerated]
	private sealed class ALGLIOKEMAK
	{
		internal bool HHFFNOHKAIC;

		internal void BDGDIDPDBHG(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void FHFECFLBHMA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void FCAGEDLBBHD(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void EFAPFFFGOOA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void AGJKEBOPIOC(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void IGFOBPKFCDJ(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void MGENGAEDACG(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void KGKMOLCPDIH(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void FIPCLHEKKCA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void INHOEMCLAAP(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void LHHFJBIAHCN(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void DNIMHEKGJHB(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void BMAOCLKPNNC(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void LJDLIIIPIIJ(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void FJDBPPKABJE(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void DKGPCPBNDPK(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void JDELIMPGFDJ(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void FDAIFOAGDLA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void BJMAIJDIKCN(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void OFLDIMDDLHM(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void EGKGJJGAPMN(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void DBFPGFHEGKA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void PIJAOCFAPKC(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void BKNHHGBPLGH(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void OFHCGKJFGDI(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void HBJFIOJFBHC(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void AEIFJLBBKBP(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void JBAJEMGOPDL(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void OLIGLEMPFOP(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void FHIJCPPECHA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}
	}

	[CompilerGenerated]
	private sealed class NOANBLPGKBI
	{
		internal string CBOLFPGKALK;

		internal GameScene ADPIKBBAKHP;

		internal bool AAPNNKGJEOG(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("_MainTex" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.GCLPAFADHMD();
			}
			return true;
		}

		internal bool MGAKKBPOACO(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("[Sound Manager] Audio clip is null, cannot play music" + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID;
		}

		internal bool HJKJAANIFLL(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("yes" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.isLoved;
			}
			return true;
		}

		internal bool LNDGINDKPFA(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("_FixDistance" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.KDPDAEEFMKK();
			}
			return true;
		}

		internal bool FKMMCDBGNFD(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.JAABFBDLBAK())
			{
				return IACGDFHKCAE.IDAOGFLHIBN() < 338f;
			}
			return true;
		}

		internal bool HHGPEDICCCI(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("restrictions" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID;
		}

		internal bool EEBODGOFEGB(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("request" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.isLoved;
			}
			return true;
		}

		internal bool GDHFAHAECPD(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_TimeX" + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID;
		}

		internal bool NEIDGMKKCBI(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("workshop." + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.isFunny;
			}
			return false;
		}

		internal bool BJGDNLAOMHE(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("workshop." + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID;
		}

		internal bool FDAIFOAGDLA(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("_Fade" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.JAABFBDLBAK();
			}
			return true;
		}

		internal bool KKENKEDKDJP(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("1" + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID;
		}

		internal bool JDHKPMFALCI(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.JAABFBDLBAK() && ADPIKBBAKHP.gameMode != (GameMode)6)
			{
				return ADPIKBBAKHP.gameMode == GameMode.Normal;
			}
			return true;
		}

		internal bool FBGMHPEEIFC(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)(", " + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.isLoved;
			}
			return true;
		}

		internal bool HDBKDCOEPBP(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID;
		}

		internal bool OFLNMEFFGEM(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("CameraFilterPack/Blend2Camera_Lighten" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.isFunny;
			}
			return false;
		}

		internal bool AJCIEFBMIJB(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_Value3" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID;
		}

		internal bool KPGCHLHFGLF(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("ViewMenu" + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID;
		}

		internal bool NLGPNAHNNCB(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial)
			{
				return IACGDFHKCAE.IDAOGFLHIBN() < 356f;
			}
			return true;
		}

		internal bool JJODNNPDMMH(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("OpenButton" + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID;
		}

		internal bool AEINPAGJFME(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("Yes" + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.isOfficial;
			}
			return true;
		}

		internal bool HBICJNIKCNA(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial)
			{
				return IACGDFHKCAE.difficulty >= 4.5f;
			}
			return false;
		}

		internal bool DNIMHEKGJHB(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("\" to target: " + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.GHLGPIBJELG();
			}
			return true;
		}

		internal bool LAKJJIIGHGI(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial)
			{
				if (ADPIKBBAKHP.gameMode != GameMode.Normal)
				{
					return ADPIKBBAKHP.gameMode == GameMode.Relax;
				}
				return true;
			}
			return false;
		}

		internal bool BICCHMDNNAG(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("SetSunDirectionVector" + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID;
		}

		internal bool LPBEPIPJJGA(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("VIGNETTE_DESAT" + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.isFunny;
			}
			return false;
		}

		internal bool IDDDJNEFHJM(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("EventSystem" + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.isFunny;
			}
			return true;
		}

		internal bool NFDJLPNCFJL(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.MENGIJNONGP())
			{
				if (ADPIKBBAKHP.gameMode != (GameMode)6)
				{
					return ADPIKBBAKHP.gameMode == GameMode.Relax;
				}
				return false;
			}
			return true;
		}

		internal bool BNDGNLAGBDO(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("BitsData" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID;
		}

		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("workshop." + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.isOfficial;
			}
			return false;
		}

		internal bool JFAHEIFLBMA(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("System.Single" + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.isFunny;
			}
			return false;
		}

		internal bool KKGEHCBDGDC(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("steamid" + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID;
		}

		internal bool PPAPDDGLFPJ(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_TintColor" + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID;
		}

		internal bool FHIJCPPECHA(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("_Value2" + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.GHLGPIBJELG();
			}
			return false;
		}

		internal bool NHJIAHCJHMK(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_Offsets" + IACGDFHKCAE.MMDJFDPIHLA()) == ADPIKBBAKHP.mapID;
		}

		internal bool EBEGBCEJBFI(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("mapselector.filter.subscribedonly" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.isFunny;
			}
			return true;
		}

		internal bool LOAHBGAEHAF(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && ADPIKBBAKHP.gameMode != (GameMode)8)
			{
				return ADPIKBBAKHP.gameMode == GameMode.Relax;
			}
			return true;
		}

		internal bool HMMBBDJNGGL(RanksSystem.Map IACGDFHKCAE)
		{
			if ((ObscuredString)("workshop." + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID)
			{
				return IACGDFHKCAE.isLoved;
			}
			return false;
		}

		internal bool PEOLMJGDHJK(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("workshop." + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID;
		}

		internal bool GLDCBMNHEGA(RanksSystem.Map IACGDFHKCAE)
		{
			if (IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial)
			{
				if (ADPIKBBAKHP.gameMode != GameMode.Hardcore)
				{
					return ADPIKBBAKHP.gameMode == GameMode.Normal;
				}
				return true;
			}
			return false;
		}
	}

	public Image hiddenImage;

	public ObscuredBool gameOver = false;

	public ObscuredBool isGameStarted = false;

	public AudioSampler asampler;

	[HideInInspector]
	public PlayerBase pbase;

	public GameObject levelCanvas;

	public GameObject levelCanvasImage;

	public GameObject gameOverCanvas;

	public GameObject messageCanvas;

	public GameObject spectatorCanvas;

	public GameObject messageAnimation;

	public GameObject resultText;

	public GameObject ingameUICanvas;

	public GameObject loadingCanvas;

	public UnityEvent OnGameOverEvent;

	[HideInInspector]
	public ObscuredString mapID;

	public bool usingCheckpoints = true;

	public GameMode gameMode = GameMode.Normal;

	public UnityEvent OnLoaded;

	public GameObject restartCheckpointPanel;

	public GameObject restartNoCheckpointPanel;

	public GameObject spectatePanel;

	public GameObject levelInfo;

	public GameObject levelInfoContent;

	public float calculatedmaptime;

	private ObscuredBool DGBKFMMMGIH = false;

	private List<string> NBCIEBFNLGN = new List<string>();

	private List<float> INGHGBLACKC = new List<float>();

	private string GIDJMDIODGM = string.Empty;

	private string NELDEHEICJD = string.Empty;

	private string OOJLKOMPCBI = string.Empty;

	private string PIDICMNEOJL = string.Empty;

	private GameObject OFMDCFHGEEC;

	private Text PECEGLIIALE;

	private Text NCKMNMHOIOH;

	[HideInInspector]
	public Text comboTextGO;

	private bool DILNONPDEBG;

	private ObscuredFloat HJPDDLBDGEP = 0f;

	[CompilerGenerated]
	private static Predicate<MapEvent> LNIJKGECNME;

	[CompilerGenerated]
	private static Predicate<MapEvent> CLCBJCKCBDD;

	public ObscuredFloat HPAnimationTime
	{
		get
		{
			return HJPDDLBDGEP;
		}
		set
		{
			HJPDDLBDGEP = value;
			if ((float)HJPDDLBDGEP >= 0f)
			{
				if ((bool)asampler.audioSources[0].clip)
				{
					asampler.audioSources[0].time = HJPDDLBDGEP;
				}
				if ((bool)asampler.audioSources[1].clip)
				{
					asampler.audioSources[1].time = HJPDDLBDGEP;
				}
			}
		}
	}

	public ObscuredFloat CurrentMusicTime
	{
		get
		{
			return float.PositiveInfinity;
		}
		set
		{
			HJPDDLBDGEP = value;
			if ((float)HJPDDLBDGEP >= 0f)
			{
				if ((bool)asampler.audioSources[1].clip)
				{
					asampler.audioSources[1].time = HJPDDLBDGEP;
				}
				if ((bool)asampler.audioSources[0].clip)
				{
					asampler.audioSources[0].time = HJPDDLBDGEP;
				}
			}
		}
	}

	public bool KLLABBCKILG()
	{
		if ((bool)gameOver)
		{
			return LBCDKGIFNLN();
		}
		return false;
	}

	public void OnStartRound()
	{
		ingameUICanvas.transform.FindDeepChild("BestScoreText").GetComponent<Text>().text = OOJLKOMPCBI + ": " + pbase.lastBestScore;
		loadingCanvas.SetActive(false);
		ingameUICanvas.SetActive(true);
		if (gameMode == GameMode.Relax)
		{
			ingameUICanvas.transform.FindDeepChild("BestScoreText").gameObject.SetActive(false);
			PECEGLIIALE.gameObject.SetActive(false);
			NCKMNMHOIOH.gameObject.SetActive(false);
			comboTextGO.gameObject.SetActive(false);
		}
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.HideChat();
		}
	}

	public void Reset()
	{
		foreach (AudioSource audioSource in asampler.audioSources)
		{
			audioSource.pitch = 1f;
			audioSource.volume = 1f;
		}
		PlayerBase[] array = UnityEngine.Object.FindObjectsOfType<PlayerBase>();
		for (int i = 0; i < array.Length; i++)
		{
			UnityEngine.Object.DestroyImmediate(array[i].gameObject);
		}
		gameOverCanvas.SetActive(false);
		spectatorCanvas.SetActive(false);
		spectatePanel.SetActive(false);
		ingameUICanvas.SetActive(false);
		restartCheckpointPanel.SetActive(false);
		restartNoCheckpointPanel.SetActive(false);
		gameOver = false;
		isGameStarted = false;
		calculatedmaptime = 0f;
		asampler.isMuted = false;
		asampler.isInited = false;
		DGBKFMMMGIH = false;
		try
		{
			OFMDCFHGEEC = ingameUICanvas.transform.Find("LevelProgressBar").gameObject;
			OFMDCFHGEEC.transform.Find("Fill Area").Find("Fill").GetComponent<Image>()
				.color = new Color(0.654902f, 0.8784314f, 0.9843137f);
			OFMDCFHGEEC.GetComponent<Slider>().value = 0f;
		}
		catch (Exception)
		{
		}
		try
		{
			PECEGLIIALE = ingameUICanvas.transform.FindDeepChild("ScoreText").GetComponent<Text>();
			PECEGLIIALE.text = LocalizationService.Instance.GetLocalizatedText("#score").ToUpper() + ": " + 0;
		}
		catch (Exception)
		{
		}
		try
		{
			DILNONPDEBG = Singleton<SaveSystem>.Instance.GetBool("settings.showHP", true);
			NCKMNMHOIOH = ingameUICanvas.transform.FindDeepChild("HPText").GetComponent<Text>();
			NCKMNMHOIOH.text = string.Empty;
		}
		catch (Exception)
		{
		}
		try
		{
			comboTextGO = ingameUICanvas.transform.FindDeepChild("ComboText").GetComponent<Text>();
			comboTextGO.text = LocalizationService.Instance.GetLocalizatedText("#combo").ToUpper() + ": " + 0;
		}
		catch (Exception)
		{
		}
		ShowCursor(false);
	}

	public void AddMessage(string JKPJCEMPAGH, float EHHBHEJBHNG = 1f)
	{
		NBCIEBFNLGN.Add(JKPJCEMPAGH);
		INGHGBLACKC.Add(EHHBHEJBHNG);
	}

	public void ANHKDCELHOI(bool AAGGLAGLINL = false)
	{
		if (AAGGLAGLINL)
		{
			gameOverCanvas.SetActive(false);
		}
		if (!NCGHKCCPKEI())
		{
			spectatePanel.SetActive(false);
		}
		else
		{
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(false);
				restartNoCheckpointPanel.SetActive(false);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(true);
				restartCheckpointPanel.SetActive(true);
			}
			NCNNIELHLMF();
			if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount > 1 && GetComponent<NetworkScene>().firstPlayer.player != null && GetComponent<NetworkScene>().firstPlayer.player == PhotonNetwork.player)
			{
				Helpers.ObtainAchievement(-113);
			}
		}
		GameObject gameObject = levelInfoContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelInfo, mapData, gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (mapData.source == FullMapData.MapSource.Workshop && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(mapData.workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().NFKCMJBAMCO();
		}
	}

	public void HBLJFFHIFGC(string NOJGGCLPPAM = "")
	{
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.ShowChat();
		}
		gameOver = true;
		GetComponent<NetworkScene>().CAMGJGEKDHD();
		if (AllPlayersFinished())
		{
			HJPDDLBDGEP = calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			OFMDCFHGEEC.transform.Find("close").Find("_TimeX").GetComponent<Image>()
				.color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != "Received RPC \"")
		{
			PhotonView photonView = GetComponent<NetworkScene>().NABDKNPNEMM();
			string lBLKDNNPACO = "[PlayerController] ";
			PhotonTargets mPNMOONBMII = PhotonTargets.All;
			object[] array = new object[7];
			array[1] = PhotonNetwork.playerName;
			array[1] = "MusicFileSelector";
			photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
		}
		if (NOJGGCLPPAM == "Please attach component to a Graphical UI component")
		{
			pbase.isMapCompleted = false;
			pbase.isPlayerWon = true;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount >= 3)
		{
			Helpers.ObtainAchievement(120);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount == 0)
		{
			Helpers.ObtainAchievement(-73);
		}
		if (gameMode != 0 && pbase.GetCurrentScore() > pbase.lastBestScore && !pbase.scoreBeated && pbase.currentAttempt > 1)
		{
			StartCoroutine(LIFALOLAPMP());
		}
		string CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		if (mapData.source == (FullMapData.MapSource)7 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			CBOLFPGKALK = mapData.workshopId;
		}
		pbase.DGKPBFLJIFI();
		if (pbase.BAJOKIEEOOJ() >= 1 && GameManager.IsOwner() && Singleton<SaveSystem>.Instance.KFNFNKILGPH("_FarCamera", 0) == 0 && mapData.source != 0 && gameMode != 0 && !string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.PHHDJOBLEMF(ulong.Parse(CBOLFPGKALK), true))
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "_Glow" + Helpers.levelConfigFileName;
			string eAFAMAMDNEG = "Start Color's hex value #RRGGBBAA";
			if (pbase.Replay() != null)
			{
				eAFAMAMDNEG = JsonConvert.SerializeObject(pbase.Replay());
			}
			StartCoroutine(Singleton<RanksSystem>.Instance.SubmitScore(CBOLFPGKALK, gameMode, pbase.BAJOKIEEOOJ(), pbase.accuracyScore, pbase.incorrectScore, EGOPKJHICLK.CompressString(eAFAMAMDNEG), Helpers.CalculateMD5(dDAOMDPAIEP)));
		}
		Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
		string hFEFHOPOLIK = "_TimeX" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "bad";
		int dPNHODJHGJL = Singleton<SaveSystem>.Instance.HHBIEPMBICO("_TimeX" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + " This is not possible to be called for standalone input. Please check your platform and code where this is called", 1) + 1;
		Singleton<SaveSystem>.Instance.DAAJKCCCICP(hFEFHOPOLIK, dPNHODJHGJL);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.accuracy = pbase.accuracyScore;
			finishedMapInfo.KJIANIGMAHL(pbase.isMapCompleted);
			finishedMapInfo.isstoryboardactive = Singleton<SaveSystem>.Instance.CHBOJJOHCEB("Tab1Content", true);
			finishedMapInfo.OBENJJNMPCL((int)gameMode);
			finishedMapInfo.NLHONELLCNN(pbase.loopsCount);
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)))
			{
				finishedMapInfo.COJIPONIHHD(RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("\" to target: " + IACGDFHKCAE.id) == mapID) || IACGDFHKCAE.GHLGPIBJELG()));
				finishedMapInfo.PEIIDGDGBMJ(RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("yes" + IACGDFHKCAE.id) == mapID) || IACGDFHKCAE.isLoved));
				finishedMapInfo.OMGMALOJDPB(RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isFunny));
			}
			else
			{
				finishedMapInfo.isofficial = true;
				finishedMapInfo.ALLGEBFFHNM(false);
				finishedMapInfo.OMGMALOJDPB(false);
			}
			finishedMapInfo.NBJNLNEKBKM(PhotonNetwork.offlineMode);
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.multiplayerplace = GetComponent<NetworkScene>().place;
			if (RanksSystem.JBJDLHKLEMN().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("steamid" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID) != null)
			{
				finishedMapInfo.mapdifficulty = RanksSystem.JBJDLHKLEMN().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("_Value3" + IACGDFHKCAE.id) == mapID).KNKHGMLPOOP();
			}
			else
			{
				finishedMapInfo.HPFOLIBCHIC(1093f);
			}
			finishedMapInfo.GBKFIPJOBPE(Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount);
			finishedMapInfo.KMADNCIJJDN(mapID);
			finishedMapInfo.maptags = string.Join("settings.disablestoryboard", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			finishedMapInfo.CFAPNLGGNOM(string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID);
			finishedMapInfo.misses = pbase.incorrectScore;
			finishedMapInfo.LJDGONNDCJP(pbase.perfectHits);
			finishedMapInfo.time = OBANGBMECKE();
			finishedMapInfo.LAAMICHIJBO(pbase.BAJOKIEEOOJ());
			foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.GameEvent(gameEventInfo);
			}
			pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.JMCBNFNJINF(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if ((bool)pbase.isPlayerWon && gameMode != 0)
		{
			string hFEFHOPOLIK2 = ":" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "CameraFilterPack/Blend2Camera_DarkerColor";
			int dPNHODJHGJL2 = 1;
			Singleton<SaveSystem>.Instance.SetInt(hFEFHOPOLIK2, dPNHODJHGJL2);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(-110);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(mapID).source == (FullMapData.MapSource)6)
			{
				Helpers.ObtainAchievement(49);
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.MENGIJNONGP() || (gameMode != (GameMode)6 && gameMode == GameMode.Relax)) && !Singleton<SaveSystem>.Instance.JMLMIGBEKJN("_Value4" + mapID, true))
			{
				Singleton<SaveSystem>.Instance.SetBool("1177138211" + mapID, false);
				Helpers.AddToStat("_EdgeSize", 0);
				SteamUserStats.IndicateAchievementProgress("SpawnObj", (uint)Helpers.GetStat("OK"), 4294967278u);
			}
			int dPNHODJHGJL3 = (int)((float)pbase.accuracyScore * (float)(int)pbase.correctScore);
			Helpers.AddToStat("?", dPNHODJHGJL3);
			pbase.LGCKKLCCLJI();
			if ((float)pbase.accuracyScore >= 201f && mapData.source == (FullMapData.MapSource)7 && RanksSystem.MLIKFMPFDCO(ulong.Parse(CBOLFPGKALK)) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && IACGDFHKCAE.difficulty >= 4.5f))
			{
				Helpers.ObtainAchievement(-35);
			}
		}
		if ((bool)pbase.isPlayerWon && gameMode == GameMode.Relax && mapData.source == (FullMapData.MapSource)4)
		{
			Helpers.AddToStat("#rate!", 1);
			SteamUserStats.IndicateAchievementProgress("ERROR You should never change PhotonPlayer IDs!", (uint)Helpers.GetStat("Y"), 3u);
			if (RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK)) && (int)pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(-62);
			}
		}
		if (mapData.source == (FullMapData.MapSource)4 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		resultText.GetComponent<Text>().text = ((!pbase.isPlayerWon) ? LocalizationService.Instance.GetTextByKey("Lerp speed. Recomended 10").ToUpper() : LocalizationService.Instance.MPHMJLAOHAB("In Network lobby").ToUpper());
		OnGameOverEvent.Invoke();
		ANHKDCELHOI(true);
		gameOver = true;
	}

	public void NPPBOPLOOOA()
	{
		pbase.SpectateNext(true);
		StartCoroutine(UpdateSpectatingInfo());
	}

	public ObscuredFloat PBBJINIKGLK()
	{
		return HJPDDLBDGEP;
	}

	public void OHILNKMCIPL(string JKPJCEMPAGH, float EHHBHEJBHNG = 1f)
	{
		NBCIEBFNLGN.Add(JKPJCEMPAGH);
		INGHGBLACKC.Add(EHHBHEJBHNG);
	}

	public void INOIAAFKALC()
	{
		pbase.SpectateNext(false);
		StartCoroutine(FIIAJAEOJIJ());
	}

	public void OnExitButton()
	{
		if (PhotonNetwork.offlineMode && mapID != (ObscuredString)"original.tutorial")
		{
			Singleton<SaveSystem>.Instance.SetBool("menu.playedsolo", true);
		}
		if (pbase != null)
		{
			pbase.DeletePlayerData();
			if (PhotonNetwork.offlineMode)
			{
				PhotonNetwork.offlineMode = false;
			}
		}
		GetComponent<NetworkScene>().OnExitButton(0);
		Singleton<SaveSystem>.Instance.Flush();
	}

	public IEnumerator FNCEGHOGDBL(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
	}

	public void OOHHBLGNGJA(bool AAGGLAGLINL = false)
	{
		if (AAGGLAGLINL)
		{
			gameOverCanvas.SetActive(false);
		}
		if (!NCGHKCCPKEI())
		{
			spectatePanel.SetActive(true);
		}
		else
		{
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(false);
				restartNoCheckpointPanel.SetActive(false);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(true);
				restartCheckpointPanel.SetActive(true);
			}
			SelectRestartButton();
			if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount > 1 && GetComponent<NetworkScene>().firstPlayer.player != null && GetComponent<NetworkScene>().firstPlayer.player == PhotonNetwork.player)
			{
				Helpers.ObtainAchievement(-22);
			}
		}
		GameObject gameObject = levelInfoContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelInfo, mapData, gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (mapData.source == FullMapData.MapSource.Workshop && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(mapData.workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().GDKEOJGALGK();
		}
	}

	public void BHEIDHGKFAH()
	{
		ingameUICanvas.transform.FindDeepChild("UI/Particles/Hidden").GetComponent<Text>().text = OOJLKOMPCBI + "_DistortionLevel" + pbase.lastBestScore;
		loadingCanvas.SetActive(false);
		ingameUICanvas.SetActive(false);
		if (gameMode == GameMode.Relax)
		{
			ingameUICanvas.transform.FindDeepChild(" Owner called.").gameObject.SetActive(true);
			PECEGLIIALE.gameObject.SetActive(false);
			NCKMNMHOIOH.gameObject.SetActive(false);
			comboTextGO.gameObject.SetActive(false);
		}
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.KDOGNHMDLJK();
		}
	}

	public void PLNLNCDPPGG()
	{
	}

	[CompilerGenerated]
	private bool CFNBNJJBPFB(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.isLoved;
		}
		return false;
	}

	public void LPAJJOLBAAJ()
	{
		restartCheckpointPanel.SetActive(true);
		restartNoCheckpointPanel.SetActive(false);
		gameOverCanvas.SetActive(false);
		spectatorCanvas.SetActive(true);
		StartCoroutine(HLOFPDDDDBH());
		pbase.JOIDLJPOLAB();
	}

	private IEnumerator GPKPFHANADA()
	{
		yield return new WaitForSeconds(1f);
		pbase.scoreBeated = true;
		Debug.Log("[PlayerBase] New highscore");
		AddMessage(LocalizationService.Instance.GetLocalizatedText("#newhighscore"));
		string hFEFHOPOLIK = string.Concat("maps.", mapID, ".", gameMode.ToString().ToLower(), ".highscore");
		if (gameMode == GameMode.Normal)
		{
			hFEFHOPOLIK = string.Concat("maps.", mapID, ".highscore");
		}
		int currentScore = pbase.GetCurrentScore();
		Singleton<SaveSystem>.Instance.SetInt(hFEFHOPOLIK, currentScore);
	}

	public ObscuredFloat LHBKKELHJKJ()
	{
		return HJPDDLBDGEP;
	}

	public void GBFJCDFGKCD(ObscuredFloat DPNHODJHGJL)
	{
		HJPDDLBDGEP = DPNHODJHGJL;
		if ((float)HJPDDLBDGEP >= 255f)
		{
			if ((bool)asampler.audioSources[1].clip)
			{
				asampler.audioSources[0].time = HJPDDLBDGEP;
			}
			if ((bool)asampler.audioSources[0].clip)
			{
				asampler.audioSources[1].time = HJPDDLBDGEP;
			}
		}
	}

	public void PEAEGEDJOBG(string NOJGGCLPPAM = "")
	{
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.ShowChat();
		}
		gameOver = true;
		GetComponent<NetworkScene>().UpdateScoreboard();
		if (AllPlayersFinished())
		{
			HJPDDLBDGEP = calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			OFMDCFHGEEC.transform.Find("CameraFilterPack/Distortion_Noise").Find("_BorderSize").GetComponent<Image>()
				.color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != "#tryagain")
		{
			PhotonView photonView = GetComponent<NetworkScene>().IJBFILBDGDO();
			string lBLKDNNPACO = "ItemNameBGImage";
			PhotonTargets mPNMOONBMII = PhotonTargets.Others;
			object[] array = new object[1];
			array[0] = PhotonNetwork.playerName;
			array[1] = ".lastCheckpoint.currentCombo";
			photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
		}
		if (NOJGGCLPPAM == "settings.gamemessagesduration")
		{
			pbase.isMapCompleted = true;
			pbase.isPlayerWon = true;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount >= 1)
		{
			Helpers.ObtainAchievement(-111);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount == 1)
		{
			Helpers.ObtainAchievement(68);
		}
		if (gameMode != 0 && pbase.GetCurrentScore() > pbase.lastBestScore && !pbase.scoreBeated && pbase.currentAttempt > 1)
		{
			StartCoroutine(DBNMOBILJHL());
		}
		string CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		if (mapData.source == (FullMapData.MapSource)7 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			CBOLFPGKALK = mapData.workshopId;
		}
		pbase.DGKPBFLJIFI();
		if (pbase.BAJOKIEEOOJ() >= 0 && GameManager.IsOwner() && Singleton<SaveSystem>.Instance.KFNFNKILGPH("note.4", 1) == 0 && mapData.source != 0 && gameMode != 0 && !string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.PHHDJOBLEMF(ulong.Parse(CBOLFPGKALK)))
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "FinalScoreSmallText" + Helpers.levelConfigFileName;
			string eAFAMAMDNEG = "settings.selectormapsperpage";
			if (pbase.Replay() != null)
			{
				eAFAMAMDNEG = JsonConvert.SerializeObject(pbase.Replay());
			}
			StartCoroutine(Singleton<RanksSystem>.Instance.SubmitScore(CBOLFPGKALK, gameMode, pbase.BAJOKIEEOOJ(), pbase.accuracyScore, pbase.incorrectScore, EGOPKJHICLK.CompressString(eAFAMAMDNEG), Helpers.CalculateMD5(dDAOMDPAIEP)));
		}
		Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
		string hFEFHOPOLIK = "_Params1" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "[PlayerController] ";
		int @int = Singleton<SaveSystem>.Instance.GetInt("player.quantum" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "Committing changes...", 1);
		Singleton<SaveSystem>.Instance.SetInt(hFEFHOPOLIK, @int);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.JPCLCMDINFD(pbase.accuracyScore);
			finishedMapInfo.completed = pbase.isMapCompleted;
			finishedMapInfo.isstoryboardactive = !Singleton<SaveSystem>.Instance.CHBOJJOHCEB("ResetButton", false);
			finishedMapInfo.gamemode = (int)gameMode;
			finishedMapInfo.NLHONELLCNN(pbase.loopsCount);
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)))
			{
				finishedMapInfo.isofficial = RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("\" to target: " + IACGDFHKCAE.id) == mapID) || IACGDFHKCAE.GHLGPIBJELG());
				finishedMapInfo.ALLGEBFFHNM(RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("yes" + IACGDFHKCAE.id) == mapID) || IACGDFHKCAE.isLoved));
				finishedMapInfo.DCEBDGNIOMI(RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("CameraFilterPack/Blend2Camera_Lighten" + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isFunny));
			}
			else
			{
				finishedMapInfo.BAHPHPGJKNH(true);
				finishedMapInfo.AAECLNDIEJO(true);
				finishedMapInfo.DCEBDGNIOMI(true);
			}
			finishedMapInfo.NBJNLNEKBKM(PhotonNetwork.offlineMode);
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.ICIHBFHNCEK(GetComponent<NetworkScene>().place);
			if (RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("OpenButton" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID) != null)
			{
				finishedMapInfo.HPFOLIBCHIC(RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID).IDAOGFLHIBN());
			}
			else
			{
				finishedMapInfo.HPFOLIBCHIC(16f);
			}
			finishedMapInfo.ICMIGLKKMGB(Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount);
			finishedMapInfo.LECMMNPDAEB(mapID);
			finishedMapInfo.ODOJJJBOMFC(string.Join(".sawoutdatedmessage", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray()));
			finishedMapInfo.OBNONHLFLIK(string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID);
			finishedMapInfo.NBGPOOIKAHC(pbase.incorrectScore);
			finishedMapInfo.LJDGONNDCJP(pbase.perfectHits);
			finishedMapInfo.time = LEFLMCJDFJP();
			finishedMapInfo.score = pbase.BAJOKIEEOOJ();
			foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.BFFBAOFFMJM(gameEventInfo);
			}
			pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.DBPNHMBLICN(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if ((bool)pbase.isPlayerWon && gameMode != 0)
		{
			string hFEFHOPOLIK2 = "SetCrosshairColor" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + ".lastCheckpoint.maxLongestCombo";
			int dPNHODJHGJL = 1;
			Singleton<SaveSystem>.Instance.OFPCEFFGHPI(hFEFHOPOLIK2, dPNHODJHGJL);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(38);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(mapID).source == (FullMapData.MapSource)3)
			{
				Helpers.ObtainAchievement(-96);
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && (gameMode == GameMode.Normal || gameMode == GameMode.Relax)) && !Singleton<SaveSystem>.Instance.JMLMIGBEKJN("Unknown player asked for PickupItems" + mapID, false))
			{
				Singleton<SaveSystem>.Instance.GIKPOGCBJFI("_ScreenResolution" + mapID, false);
				Helpers.AddToStat("_Value", 1);
				SteamUserStats.IndicateAchievementProgress("_LutTex", (uint)Helpers.GetStat("#ok"), 4294967201u);
			}
			int dPNHODJHGJL2 = (int)((float)pbase.accuracyScore * (float)(int)pbase.correctScore);
			Helpers.AddToStat("_Value2", dPNHODJHGJL2);
			pbase.LGCKKLCCLJI();
			if ((float)pbase.accuracyScore >= 1082f && mapData.source == (FullMapData.MapSource)3 && RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK)) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.JAABFBDLBAK() || IACGDFHKCAE.IDAOGFLHIBN() < 338f))
			{
				Helpers.ObtainAchievement(45);
			}
		}
		if ((bool)pbase.isPlayerWon && gameMode == GameMode.Relax && mapData.source == FullMapData.MapSource.Original)
		{
			Helpers.AddToStat("Stream did not contain properly formatted byte array", 1);
			SteamUserStats.IndicateAchievementProgress("Set particles gravity", (uint)Helpers.GetStat("CameraFilterPack/FX_Ascii"), 3u);
			if (RanksSystem.PHHDJOBLEMF(ulong.Parse(CBOLFPGKALK)) && (int)pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(-98);
			}
		}
		if (mapData.source == (FullMapData.MapSource)3 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		resultText.GetComponent<Text>().text = ((!pbase.isPlayerWon) ? LocalizationService.Instance.JNNKPEBBDEA("_BlurCoe").ToUpper() : LocalizationService.Instance.HOFKLNAJGMK(".lastCheckpoint.powerupsScore").ToUpper());
		OnGameOverEvent.Invoke();
		HDOHOBPLMEN(true);
		gameOver = false;
	}

	public bool ODAFCOMJMCH()
	{
		if ((bool)gameOver)
		{
			return NCGHKCCPKEI();
		}
		return false;
	}

	private bool EBKBPBFOHKK(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("https://steamcommunity.com/app/513510/workshop/" + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.GCLPAFADHMD();
		}
		return false;
	}

	public IEnumerator JEKHBLMDABM()
	{
		ulong num = 0uL;
		try
		{
			num = ulong.Parse(PhotonNetwork.playerList[pbase.spectrid].NickName);
		}
		catch (Exception)
		{
		}
		Sprite sprite = null;
		CSteamID csteamID = new CSteamID(num);
		if (num != 0L)
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
			if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
			{
				sprite = ResourcesManager.GetLoadedAvatar(csteamID);
			}
		}
		GameObject.Find("SpectatingUserInfo").transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
		GameObject.Find("SpectatingUserInfo").transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
	}

	public virtual void EGEGNHLODAA()
	{
		base.AEEGKLABFLN();
		if (!isGameStarted && JMLNPHJNDCG())
		{
			pbase.ACPGHFHDCIP().RPC("CloseConnection: Only the masterclient can kick another player.", PhotonTargets.AllBufferedViaServer, null);
		}
		if ((bool)isGameStarted && (float)HJPDDLBDGEP > 365f && !DGBKFMMMGIH)
		{
			asampler.audioSources[0].time = HJPDDLBDGEP;
			asampler.audioSources[0].time = HJPDDLBDGEP;
			asampler.EFGFFEECBAF(1);
			asampler.Play(0);
			DGBKFMMMGIH = true;
		}
		if ((float)HJPDDLBDGEP < calculatedmaptime && !HIKLFECACDJ() && (bool)isGameStarted)
		{
			HJPDDLBDGEP = (float)HJPDDLBDGEP + Time.deltaTime;
			OFMDCFHGEEC.GetComponent<Slider>().value = HJPDDLBDGEP;
			PlayerBase spectatedPlayerBase = pbase;
			if (pbase.currentState == (PlayerBase.PlayerState)7 && pbase.spectatedPlayerBase != null)
			{
				spectatedPlayerBase = pbase.spectatedPlayerBase;
			}
			if (DILNONPDEBG)
			{
				if (gameMode != GameMode.Normal)
				{
					Text nCKMNMHOIOH = NCKMNMHOIOH;
					object[] array = new object[4];
					array[0] = NELDEHEICJD;
					array[0] = "_VignetteTex";
					array[3] = spectatedPlayerBase.GIDCIBDGKGI();
					array[4] = "_TimeX";
					array[2] = spectatedPlayerBase.fullLevelData.mapData.maxLives;
					nCKMNMHOIOH.text = string.Concat(array);
				}
				else
				{
					NCKMNMHOIOH.text = NELDEHEICJD + "USE_CORNER_DETECTION" + (Math.Floor((float)spectatedPlayerBase.accuracyScore * 759f) / 306.0 * 855.0).ToString("Load scene by name or build id") + "[NetworkManager] Connection failed: ";
				}
			}
			PECEGLIIALE.text = GIDJMDIODGM + "player.yellowarc" + spectatedPlayerBase.BAJOKIEEOOJ();
			Text text = comboTextGO;
			object[] array2 = new object[0];
			array2[0] = PIDICMNEOJL;
			array2[0] = "Joystick1Button3";
			array2[5] = "The given 2D texture ";
			array2[2] = spectatedPlayerBase.currentCombo;
			text.text = string.Concat(array2);
			if (hardInput.EBAHBLEMKKC("StartButton") && PhotonNetwork.offlineMode)
			{
				foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
				{
					Singleton<GameManager>.Instance.ELKPGFANDCG(gameEventInfo);
				}
				pbase.gameEventInfoList.Clear();
				OIKOFEHGKGM(false);
			}
		}
		if ((bool)gameOver && pbase.currentState == (PlayerBase.PlayerState)7)
		{
			ingameUICanvas.SetActive(true);
			if (LBCDKGIFNLN())
			{
				foreach (AudioSource audioSource in asampler.audioSources)
				{
					if (!pbase.isPlayerWon)
					{
						audioSource.pitch = Mathf.Lerp(audioSource.pitch, 830f, Time.deltaTime * 321f);
					}
					audioSource.volume = Mathf.Lerp(audioSource.volume, 1613f, Time.deltaTime * 878f);
				}
				asampler.isMuted = false;
			}
			string CBOLFPGKALK = string.Empty;
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
			if (mapData.source == (FullMapData.MapSource)7 && !string.IsNullOrEmpty(mapData.workshopId))
			{
				CBOLFPGKALK = mapData.workshopId;
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.JAABFBDLBAK() || gameMode == GameMode.Hardcore || gameMode == GameMode.Relax))
			{
				if ((bool)GameObject.Find(" not found"))
				{
					GameObject.Find("Jazz").SetActive(false);
				}
			}
			else
			{
				if ((bool)GameObject.Find("DataText"))
				{
					GameObject.Find("/").SetActive(false);
				}
				if ((bool)GameObject.Find("BitsData"))
				{
					GameObject.Find("{0:0} hour{1}, ").SetActive(true);
				}
				if ((bool)GameObject.Find("default"))
				{
					GameObject.Find("] to be droppable").SetActive(false);
				}
				if ((bool)GameObject.Find("_Visualize"))
				{
					GameObject.Find("_TimeX").SetActive(true);
				}
			}
			if ((gameMode == GameMode.Normal || gameMode == GameMode.Hardcore) && (bool)GameObject.Find("settings.hideui"))
			{
				GameObject.Find("_Fade").SetActive(false);
			}
			if (gameMode != (GameMode)8 && (bool)GameObject.Find("_TintColor"))
			{
				GameObject.Find("_ScreenResolution").SetActive(true);
			}
			int currentScore = pbase.GetCurrentScore();
			if ((bool)GameObject.Find("LostAllLives"))
			{
				GameObject.Find("Updating...").GetComponent<Text>().text = string.Empty + pbase.lastBestScore;
			}
			if ((bool)GameObject.Find("CameraFilterPack/Blur_Blurry"))
			{
				GameObject.Find("The observed monobehaviour (").GetComponent<Text>().text = string.Empty + Helpers.GetMapMaxScore(pbase.fullLevelData.mapData);
			}
			if ((bool)GameObject.Find("d264dbba9c2410771b4ad918903b3f4cd9e276a9"))
			{
				GameObject.Find("_Value6").GetComponent<Text>().text = string.Empty + LocalizationService.Instance.GetLocalizatedText("_BgFade" + gameMode.ToString().ToLower() + "Case-Sensitive").ToUpper();
			}
			if ((bool)GameObject.Find("CountEventsGoal"))
			{
				GameObject.Find("_Offsets").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if ((bool)GameObject.Find("settings.enablehitsoundsinrelax"))
			{
				GameObject.Find("_CenterX").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore + (int)pbase.incorrectScore);
			}
			if ((bool)GameObject.Find("#submit"))
			{
				GameObject.Find(". Check if the server is available.").GetComponent<Text>().text = string.Empty + pbase.perfectHits;
			}
			if ((bool)GameObject.Find("_Blue_G"))
			{
				GameObject.Find("MapEditorScene").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore - (int)pbase.perfectHits);
			}
			if ((bool)GameObject.Find("_Intensity"))
			{
				GameObject.Find(",").GetComponent<Text>().text = string.Empty + pbase.incorrectScore;
			}
			if ((bool)GameObject.Find("[ERROR KEY {0}]"))
			{
				GameObject.Find("CameraFilterPack/Vision_Plasma").GetComponent<Text>().text = string.Empty + Mathf.RoundToInt(pbase.comboScore);
			}
			if ((bool)GameObject.Find("1427616858"))
			{
				GameObject.Find("turn: {0:0}").GetComponent<Text>().text = string.Empty + Mathf.CeilToInt(pbase.penaltyScore);
			}
			if ((bool)GameObject.Find("InventoryButton"))
			{
				GameObject.Find("_Green_R").GetComponent<Text>().text = string.Empty + (Math.Floor((float)pbase.accuracyScore * 1919f) / 1722.0 * 143.0).ToString("Need to specify a start index and end index.") + "#91CCFF";
			}
			if ((bool)GameObject.Find("_Alpha2"))
			{
				GameObject.Find("Keeping GameObject in the scene: ").GetComponent<Text>().text = string.Empty + pbase.checkpointsUsed;
			}
			if ((bool)GameObject.Find("_ScreenResolution"))
			{
				GameObject.Find("_Distortion").GetComponent<Text>().text = string.Empty + pbase.loopsCount;
			}
			if ((bool)GameObject.Find("SpawnObj"))
			{
				float num = (float)pbase.lastBestScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK)).difficulty;
				GameObject.Find("menu.selectedplaymode").GetComponent<Text>().text = string.Empty + (Math.Floor(num * 1397f) / 600.0).ToString("Most likely the game became empty during the switch to GameServer.");
			}
			if ((bool)GameObject.Find("Please define the RectTransform for the Center viewport of the scrollable area"))
			{
				GameObject.Find("GameScene").GetComponent<Text>().text = string.Empty + RanksSystem.JBJDLHKLEMN().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK)).KNKHGMLPOOP()
					.ToString(" | Level: ");
			}
			if ((bool)GameObject.Find("FinalScoreText"))
			{
				float num2 = (float)currentScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK)).IDAOGFLHIBN();
				num2 = ((num2 >= 1646f) ? num2 : 1490f);
				GameObject.Find(":</b> ").GetComponent<Text>().text = string.Empty + (Math.Floor(num2 * 692f) / 242.0).ToString("_Far");
			}
			if ((bool)GameObject.Find("MaxLivesSlider"))
			{
				GameObject.Find("_TapLowBackground").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if (restartNoCheckpointPanel.transform.Find("_LightIntensity").gameObject.activeInHierarchy && !PhotonNetwork.offlineMode)
			{
				restartNoCheckpointPanel.transform.Find(".g").gameObject.GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient) ? LocalizationService.Instance.EIJLFGIMNPC("ChallengesButton").ToUpper() : LocalizationService.Instance.MPHMJLAOHAB("MenuScene").ToUpper());
			}
			if (!PhotonNetwork.isMasterClient && PhotonNetwork.inRoom && (bool)GameObject.Find("_Value"))
			{
				GameObject.Find("<color=white>PhotonView Group: ").GetComponent<Button>().interactable = false;
			}
			if (!PhotonNetwork.offlineMode && PhotonNetwork.inRoom)
			{
				GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
			}
		}
		if ((bool)gameOver && Singleton<RanksSystem>.Instance.isRankChanged)
		{
			Singleton<RanksSystem>.Instance.CKLHHPBMNBC();
		}
		if ((bool)gameOver && Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
		{
			Singleton<ItemsHandler>.Instance.EEJELODJPNL();
		}
		if ((bool)gameOver && Singleton<ChallengesManager>.Instance.LFGEKLNBDAD())
		{
			Singleton<ChallengesManager>.Instance.PCBHFLCFPIO();
		}
		if (AllPlayersFinished() && pbase.currentState == (PlayerBase.PlayerState)8 && spectatePanel.activeSelf)
		{
			gameOverCanvas.SetActive(true);
			spectatorCanvas.SetActive(true);
			spectatePanel.SetActive(false);
			ingameUICanvas.SetActive(true);
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(true);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(false);
			}
		}
		if (MJOLOHPNJDK() && pbase.currentState == PlayerBase.PlayerState.Finished)
		{
			gameOverCanvas.SetActive(false);
			spectatorCanvas.SetActive(true);
			spectatePanel.SetActive(true);
			ingameUICanvas.SetActive(true);
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(false);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(true);
			}
			pbase.currentState = (PlayerBase.PlayerState)8;
		}
		if ((bool)isGameStarted && (bool)pbase && PhotonNetwork.inRoom && (bool)pbase.isPlayerWon && !PhotonNetwork.offlineMode && IDLFGLPOCBG())
		{
			int playerCount = PhotonNetwork.room.PlayerCount;
			int num4 = 0;
		}
		if ((bool)isGameStarted && (float)HJPDDLBDGEP > calculatedmaptime && !gameOver)
		{
			bool HHFFNOHKAIC = true;
			pbase.playerController.objects.ForEach(delegate(GameObject IACGDFHKCAE)
			{
				if (IACGDFHKCAE.transform.childCount > 1)
				{
					HHFFNOHKAIC = true;
				}
			});
			if (HHFFNOHKAIC)
			{
				pbase.isMapCompleted = true;
				if (gameMode != 0)
				{
					ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { { "_Value3", false } };
					PhotonNetwork.player.LBNGJPNOHMN(eNEEBHGAAJH);
					pbase.currentState = (PlayerBase.PlayerState)8;
					if (pbase.FFIPLLNKGEN().isMine)
					{
						ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = new ExitGames.Client.Photon.Hashtable { { "[Right-Left]", true } };
						PhotonNetwork.player.LBNGJPNOHMN(eNEEBHGAAJH2);
					}
					PAIKPLKDKJG("RequestForPickupItems");
				}
				else
				{
					LKDDHMPMHEC();
				}
			}
		}
		if (NBCIEBFNLGN.Count > 1 && !messageCanvas.activeSelf)
		{
			string jKPJCEMPAGH = NBCIEBFNLGN[0];
			float num3 = 221f;
			if (INGHGBLACKC.Count == NBCIEBFNLGN.Count)
			{
				num3 = INGHGBLACKC[1];
			}
			StartCoroutine(CPNDMFMIBKJ(jKPJCEMPAGH, num3 * Singleton<SaveSystem>.Instance.GetFloat(" has been disabled as it's not supported on the current platform.", 425f)));
			NBCIEBFNLGN.RemoveAt(1);
			INGHGBLACKC.RemoveAt(1);
		}
	}

	public void LKPBGHGCPKL()
	{
	}

	public bool AllPlayersFinished()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		foreach (PhotonPlayer photonPlayer in playerList)
		{
			if (photonPlayer.CustomProperties["finished"] == null || (photonPlayer.CustomProperties["finished"] != null && !(bool)photonPlayer.CustomProperties["finished"]))
			{
				result = false;
			}
		}
		return result;
	}

	public void AJBHOEBKGDO()
	{
	}

	public void KPHFECCIHGM(string NOJGGCLPPAM = "")
	{
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.GNHOLMBIMBO();
		}
		gameOver = true;
		GetComponent<NetworkScene>().CAMGJGEKDHD();
		if (LBCDKGIFNLN())
		{
			HJPDDLBDGEP = calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			OFMDCFHGEEC.transform.Find("_MainTex2").Find("player.currentrank").GetComponent<Image>()
				.color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != ".status")
		{
			PhotonView photonView = GetComponent<NetworkScene>().NABDKNPNEMM();
			string lBLKDNNPACO = "CameraFilterPack/Colors_BleachBypass";
			PhotonTargets mPNMOONBMII = PhotonTargets.Others;
			object[] array = new object[5];
			array[1] = PhotonNetwork.playerName;
			array[1] = "LevelURLInputField";
			photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
		}
		if (NOJGGCLPPAM == ") but there is no recycle bin setup for it. Falling back to Instantiate")
		{
			pbase.isMapCompleted = true;
			pbase.isPlayerWon = true;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount >= 1)
		{
			Helpers.ObtainAchievement(-116);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount == 1)
		{
			Helpers.ObtainAchievement(35);
		}
		if (gameMode != 0 && pbase.GetCurrentScore() > pbase.lastBestScore && !pbase.scoreBeated && pbase.currentAttempt > 1)
		{
			StartCoroutine(LIFALOLAPMP());
		}
		string CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
		{
			CBOLFPGKALK = mapData.workshopId;
		}
		pbase.StopReplayRecording();
		if (pbase.BAJOKIEEOOJ() >= 1 && GameManager.IsOwner() && Singleton<SaveSystem>.Instance.KFNFNKILGPH("_ScreenResolution", 0) == 0 && mapData.source != 0 && gameMode != 0 && !string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK)))
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "Object ID. Case-Sensitive" + Helpers.levelConfigFileName;
			string eAFAMAMDNEG = " - GameWebCallback] - ";
			if (pbase.Replay() != null)
			{
				eAFAMAMDNEG = JsonConvert.SerializeObject(pbase.Replay());
			}
			StartCoroutine(Singleton<RanksSystem>.Instance.SubmitScore(CBOLFPGKALK, gameMode, pbase.BAJOKIEEOOJ(), pbase.accuracyScore, pbase.incorrectScore, EGOPKJHICLK.CompressString(eAFAMAMDNEG), Helpers.CalculateMD5(dDAOMDPAIEP)));
		}
		Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		string hFEFHOPOLIK = "mapselector.filter.officialsortmode" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "Editor/";
		int dPNHODJHGJL = Singleton<SaveSystem>.Instance.HHBIEPMBICO("Jul" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "[DiscordController] Responding yes to Ask to Join request", 0) + 1;
		Singleton<SaveSystem>.Instance.SetInt(hFEFHOPOLIK, dPNHODJHGJL);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.PONDJCNLBPG(pbase.accuracyScore);
			finishedMapInfo.FPONFICAAGI(pbase.isMapCompleted);
			finishedMapInfo.isstoryboardactive = !Singleton<SaveSystem>.Instance.CHBOJJOHCEB("_Offsets", true);
			finishedMapInfo.gamemode = (int)gameMode;
			finishedMapInfo.BGNOFFFJPOL(pbase.loopsCount);
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)))
			{
				finishedMapInfo.HMHFKLLJOBF(RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("_Fade" + IACGDFHKCAE.id) == mapID) || IACGDFHKCAE.JAABFBDLBAK()));
				finishedMapInfo.AAECLNDIEJO(RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("request" + IACGDFHKCAE.id) == mapID) || IACGDFHKCAE.isLoved));
				finishedMapInfo.OMGMALOJDPB(RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("EventSystem" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID) || IACGDFHKCAE.isFunny));
			}
			else
			{
				finishedMapInfo.HMHFKLLJOBF(false);
				finishedMapInfo.AAECLNDIEJO(false);
				finishedMapInfo.OMGMALOJDPB(true);
			}
			finishedMapInfo.FLNEADLCNLE(!PhotonNetwork.offlineMode);
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.ICIHBFHNCEK(GetComponent<NetworkScene>().place);
			if (RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("ViewMenu" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID) != null)
			{
				finishedMapInfo.mapdifficulty = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("BitsData" + IACGDFHKCAE.id) == mapID).difficulty;
			}
			else
			{
				finishedMapInfo.HPFOLIBCHIC(323f);
			}
			finishedMapInfo.GBKFIPJOBPE(Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount);
			finishedMapInfo.KMADNCIJJDN(mapID);
			finishedMapInfo.ODOJJJBOMFC(string.Join("_Distortion", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray()));
			finishedMapInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID;
			finishedMapInfo.NBGPOOIKAHC(pbase.incorrectScore);
			finishedMapInfo.LJDGONNDCJP(pbase.perfectHits);
			finishedMapInfo.FLJHBGENNLG(OBANGBMECKE());
			finishedMapInfo.MIFMFDDPDIA(pbase.GetCurrentScore());
			foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.LNNCKEKFPIF(gameEventInfo);
			}
			pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.CDDFCJDDMJL(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if ((bool)pbase.isPlayerWon && gameMode != 0)
		{
			string hFEFHOPOLIK2 = "musicVolume" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "SetSunColors";
			int dPNHODJHGJL2 = 1;
			Singleton<SaveSystem>.Instance.OFPCEFFGHPI(hFEFHOPOLIK2, dPNHODJHGJL2);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(-9);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(mapID).source == (FullMapData.MapSource)7)
			{
				Helpers.ObtainAchievement(-123);
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.JAABFBDLBAK() || gameMode == (GameMode)6 || gameMode == GameMode.Normal) && !Singleton<SaveSystem>.Instance.CHBOJJOHCEB(".GoalProgress" + mapID, false))
			{
				Singleton<SaveSystem>.Instance.GIKPOGCBJFI("_Red_C" + mapID, false);
				Helpers.AddToStat("settings.enableranking", 0);
				SteamUserStats.IndicateAchievementProgress("_Smooth", (uint)Helpers.GetStat("effector"), 4294967239u);
			}
			int dPNHODJHGJL3 = (int)((float)pbase.accuracyScore * (float)(int)pbase.correctScore);
			Helpers.AddToStat("_Value13", dPNHODJHGJL3);
			pbase.DeletePlayerData();
			if ((float)pbase.accuracyScore >= 1819f && mapData.source == (FullMapData.MapSource)4 && RanksSystem.PHHDJOBLEMF(ulong.Parse(CBOLFPGKALK), true) && RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.isOfficial || IACGDFHKCAE.IDAOGFLHIBN() < 356f))
			{
				Helpers.ObtainAchievement(53);
			}
		}
		if ((bool)pbase.isPlayerWon && gameMode == GameMode.Relax && mapData.source == (FullMapData.MapSource)6)
		{
			Helpers.AddToStat("open", 0);
			SteamUserStats.IndicateAchievementProgress("/", (uint)Helpers.GetStat("_ScreenResolution"), 4u);
			if (RanksSystem.MLIKFMPFDCO(ulong.Parse(CBOLFPGKALK)) && (int)pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(-94);
			}
		}
		if (mapData.source == (FullMapData.MapSource)7 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		resultText.GetComponent<Text>().text = ((!pbase.isPlayerWon) ? LocalizationService.Instance.NDAPBHEDJFP("BadgeText").ToUpper() : LocalizationService.Instance.NDAPBHEDJFP("#no").ToUpper());
		OnGameOverEvent.Invoke();
		ShowGOCanvas();
		gameOver = false;
	}

	private static bool LBMFEELDDDK(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "OK";
	}

	public ObscuredFloat HGJEOINDMOO()
	{
		return HJPDDLBDGEP;
	}

	public void OIKOFEHGKGM(bool CONOEKAENEN)
	{
		if (CONOEKAENEN)
		{
			pbase.DeletePlayerData();
		}
		else if (pbase.ach12)
		{
			Helpers.ObtainAchievement(-100);
		}
		GetComponent<NetworkScene>().photonView.RPC("_ScreenResolution", PhotonTargets.Others, SceneManager.GetActiveScene().name);
	}

	private bool CFLKJKCIAHO(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("challenges/" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID;
	}

	private static bool ENDBHILCKPP(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "_ScreenResolution";
	}

	public bool MJOLOHPNJDK()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int num = 0; num < playerList.Length; num = num)
		{
			PhotonPlayer photonPlayer = playerList[num];
			if (photonPlayer.CustomProperties["ZoomSpeed"] == null || (photonPlayer.CustomProperties["NetworkPeer broke!"] != null && !(bool)photonPlayer.CustomProperties["Cant ask anyone else for PickupItem spawn times."]))
			{
				result = false;
			}
		}
		return result;
	}

	public ObscuredFloat EHDEHMIAMED()
	{
		return 595f;
	}

	public void HDOHOBPLMEN(bool AAGGLAGLINL = false)
	{
		if (AAGGLAGLINL)
		{
			gameOverCanvas.SetActive(true);
		}
		if (!NCGHKCCPKEI())
		{
			spectatePanel.SetActive(false);
		}
		else
		{
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(true);
				restartNoCheckpointPanel.SetActive(true);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(true);
				restartCheckpointPanel.SetActive(false);
			}
			DFELFMJKDMF();
			if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount > 1 && GetComponent<NetworkScene>().firstPlayer.player != null && GetComponent<NetworkScene>().firstPlayer.player == PhotonNetwork.player)
			{
				Helpers.ObtainAchievement(-102);
			}
		}
		GameObject gameObject = levelInfoContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelInfo, mapData, gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (mapData.source == FullMapData.MapSource.Editor && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(mapData.workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().CAAAHJLFLAA();
		}
	}

	private bool HMJBPFBFCED(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("skin." + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.JAABFBDLBAK();
		}
		return true;
	}

	public void JLGNODMBBAF()
	{
		loadingCanvas.SetActive(false);
		GetComponent<NetworkScene>().networkChatCanvas.SetActive(true);
	}

	public void OKIIKJBOGFK()
	{
		if (PhotonNetwork.offlineMode && mapID != (ObscuredString)"_Size")
		{
			Singleton<SaveSystem>.Instance.BHLOCFLKPPN("Closes the app", true);
		}
		if (pbase != null)
		{
			pbase.LGCKKLCCLJI();
			if (PhotonNetwork.offlineMode)
			{
				PhotonNetwork.offlineMode = false;
			}
		}
		GetComponent<NetworkScene>().JICAAOLEGKB(0);
		Singleton<SaveSystem>.Instance.Flush();
	}

	private static bool IOMOOMFIMMK(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "_Blue_C";
	}

	public void FCKIJIKNMCF()
	{
	}

	public ObscuredFloat JFBBJAAHPAH()
	{
		return HJPDDLBDGEP;
	}

	public bool HIKLFECACDJ()
	{
		if ((bool)gameOver)
		{
			return MJOLOHPNJDK();
		}
		return false;
	}

	public void BLPKMHGFPFP(string NOJGGCLPPAM = "")
	{
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.EPPBBLLJNNH();
		}
		gameOver = true;
		GetComponent<NetworkScene>().CAMGJGEKDHD();
		if (AllPlayersFinished())
		{
			HJPDDLBDGEP = calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			OFMDCFHGEEC.transform.Find("_Blue_B").Find("hitsounds:").GetComponent<Image>()
				.color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != "_MainTex2")
		{
			PhotonView photonView = GetComponent<NetworkScene>().FFIPLLNKGEN();
			string lBLKDNNPACO = "note.6";
			PhotonTargets mPNMOONBMII = PhotonTargets.Others;
			object[] array = new object[4];
			array[0] = PhotonNetwork.playerName;
			array[0] = "MessageText";
			photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
		}
		if (NOJGGCLPPAM == "bool")
		{
			pbase.isMapCompleted = false;
			pbase.isPlayerWon = false;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount >= 4)
		{
			Helpers.ObtainAchievement(126);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount == 0)
		{
			Helpers.ObtainAchievement(-114);
		}
		if (gameMode != 0 && pbase.GetCurrentScore() > pbase.lastBestScore && !pbase.scoreBeated && pbase.currentAttempt > 0)
		{
			StartCoroutine(LIFALOLAPMP());
		}
		string CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		if (mapData.source == FullMapData.MapSource.Original && !string.IsNullOrEmpty(mapData.workshopId))
		{
			CBOLFPGKALK = mapData.workshopId;
		}
		pbase.StopReplayRecording();
		if (pbase.GetCurrentScore() >= 0 && GameManager.IsOwner() && Singleton<SaveSystem>.Instance.HHBIEPMBICO("_MainTex2", 1) == 0 && mapData.source != 0 && gameMode != 0 && !string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.ECFIOECNPOM(ulong.Parse(CBOLFPGKALK), true))
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "[NetworkMenu] Joining " + Helpers.levelConfigFileName;
			string eAFAMAMDNEG = "ViewMenu";
			if (pbase.Replay() != null)
			{
				eAFAMAMDNEG = JsonConvert.SerializeObject(pbase.Replay());
			}
			StartCoroutine(Singleton<RanksSystem>.Instance.SubmitScore(CBOLFPGKALK, gameMode, pbase.GetCurrentScore(), pbase.accuracyScore, pbase.incorrectScore, EGOPKJHICLK.CompressString(eAFAMAMDNEG), Helpers.CalculateMD5(dDAOMDPAIEP)));
		}
		Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
		string hFEFHOPOLIK = "#tryagain" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "ConfigVersionSlider";
		int dPNHODJHGJL = Singleton<SaveSystem>.Instance.HHBIEPMBICO("menu.playedpage" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "warning: Audio Source: ", 0);
		Singleton<SaveSystem>.Instance.OFPCEFFGHPI(hFEFHOPOLIK, dPNHODJHGJL);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.JPCLCMDINFD(pbase.accuracyScore);
			finishedMapInfo.FPONFICAAGI(pbase.isMapCompleted);
			finishedMapInfo.IGAFDMLBICN(!Singleton<SaveSystem>.Instance.CHBOJJOHCEB("D-Pad Left", false));
			finishedMapInfo.gamemode = (int)gameMode;
			finishedMapInfo.OAOPKANCNNN(pbase.loopsCount);
			if (RanksSystem.MLIKFMPFDCO(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId), true))
			{
				finishedMapInfo.HMHFKLLJOBF(RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("\" to target: " + IACGDFHKCAE.id) == mapID) || IACGDFHKCAE.GHLGPIBJELG()));
				finishedMapInfo.PEIIDGDGBMJ(RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isLoved));
				finishedMapInfo.DCEBDGNIOMI(RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("_MainTex" + IACGDFHKCAE.id) == mapID) || IACGDFHKCAE.GCLPAFADHMD()));
			}
			else
			{
				finishedMapInfo.HMHFKLLJOBF(true);
				finishedMapInfo.PEIIDGDGBMJ(true);
				finishedMapInfo.JKGMFMGEEDF(false);
			}
			finishedMapInfo.FLNEADLCNLE(!PhotonNetwork.offlineMode);
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.ICIHBFHNCEK(GetComponent<NetworkScene>().place);
			if (RanksSystem.JBJDLHKLEMN().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("SetSunDirectionVector" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID) != null)
			{
				finishedMapInfo.HPFOLIBCHIC(RanksSystem.JBJDLHKLEMN().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("_Offsets" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID).KNKHGMLPOOP());
			}
			else
			{
				finishedMapInfo.mapdifficulty = 673f;
			}
			finishedMapInfo.EFEAKIJBGJJ(Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount);
			finishedMapInfo.mapid = mapID;
			finishedMapInfo.maptags = string.Join("Scrollbar", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			finishedMapInfo.CFAPNLGGNOM(string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID);
			finishedMapInfo.NBGPOOIKAHC(pbase.incorrectScore);
			finishedMapInfo.perfecthits = pbase.perfectHits;
			finishedMapInfo.MDKLDNNICAK(PBBJINIKGLK());
			finishedMapInfo.score = pbase.GetCurrentScore();
			foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.MMPGEMFKNAN(gameEventInfo);
			}
			pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.JMCBNFNJINF(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if ((bool)pbase.isPlayerWon && gameMode != 0)
		{
			string hFEFHOPOLIK2 = "#,0" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "#mapby";
			int dPNHODJHGJL2 = 0;
			Singleton<SaveSystem>.Instance.SetInt(hFEFHOPOLIK2, dPNHODJHGJL2);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(-54);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(mapID).source == (FullMapData.MapSource)3)
			{
				Helpers.ObtainAchievement(46);
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && (gameMode == GameMode.Normal || gameMode == GameMode.Relax)) && !Singleton<SaveSystem>.Instance.JMLMIGBEKJN("Tab2Content" + mapID, false))
			{
				Singleton<SaveSystem>.Instance.SetBool("_Green_C" + mapID, false);
				Helpers.AddToStat("UseScanLine", 0);
				SteamUserStats.IndicateAchievementProgress("Set satellite audio input", (uint)Helpers.GetStat("_DistortionSize"), 4294967249u);
			}
			int dPNHODJHGJL3 = (int)((float)pbase.accuracyScore * (float)(int)pbase.correctScore);
			Helpers.AddToStat("Set Sun Sensitivity", dPNHODJHGJL3);
			pbase.LGCKKLCCLJI();
			if ((float)pbase.accuracyScore >= 1201f && mapData.source == FullMapData.MapSource.Workshop && RanksSystem.PHHDJOBLEMF(ulong.Parse(CBOLFPGKALK), true) && RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.isOfficial || IACGDFHKCAE.IDAOGFLHIBN() < 356f))
			{
				Helpers.ObtainAchievement(60);
			}
		}
		if ((bool)pbase.isPlayerWon && gameMode == GameMode.Relax && mapData.source == FullMapData.MapSource.Original)
		{
			Helpers.AddToStat("id", 0);
			SteamUserStats.IndicateAchievementProgress("GameScene", (uint)Helpers.GetStat("Could not execute RPC "), 6u);
			if (RanksSystem.ECFIOECNPOM(ulong.Parse(CBOLFPGKALK), true) && (int)pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(-102);
			}
		}
		if (mapData.source == (FullMapData.MapSource)5 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		resultText.GetComponent<Text>().text = ((!pbase.isPlayerWon) ? LocalizationService.Instance.MPHMJLAOHAB("_Green_B").ToUpper() : LocalizationService.Instance.GetTextByKey(" not exist").ToUpper());
		OnGameOverEvent.Invoke();
		ShowGOCanvas(true);
		gameOver = true;
	}

	public bool EBAKIPBMJKH()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["FavoriteButton"] == null || (photonPlayer.CustomProperties[" not exist"] != null && !(bool)photonPlayer.CustomProperties["Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. "]))
			{
				result = false;
			}
		}
		return result;
	}

	public bool JODCMKEAIJI()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int num = 1; num < playerList.Length; num = num)
		{
			PhotonPlayer photonPlayer = playerList[num];
			if (photonPlayer.CustomProperties["RT"] == null || (photonPlayer.CustomProperties["value"] != null && !(bool)photonPlayer.CustomProperties["_Value2"]))
			{
				result = true;
			}
		}
		return result;
	}

	public void LKDDHMPMHEC()
	{
		++pbase.loopsCount;
		StartCoroutine(CPNDMFMIBKJ(".g" + pbase.loopsCount, 274f * Singleton<SaveSystem>.Instance.GetFloat(" canvas not found", 1994f)));
		DGBKFMMMGIH = false;
		HJPDDLBDGEP = 1706f;
		pbase.ResetEndless();
	}

	public IEnumerator UpdateSpectatingInfo()
	{
		ulong num = 0uL;
		try
		{
			num = ulong.Parse(PhotonNetwork.playerList[pbase.spectrid].NickName);
		}
		catch (Exception)
		{
		}
		Sprite sprite = null;
		CSteamID csteamID = new CSteamID(num);
		if (num != 0L)
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
			if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
			{
				sprite = ResourcesManager.GetLoadedAvatar(csteamID);
			}
		}
		GameObject.Find("SpectatingUserInfo").transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
		GameObject.Find("SpectatingUserInfo").transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
	}

	public void LNLBMJNACDF()
	{
		restartCheckpointPanel.SetActive(true);
		restartNoCheckpointPanel.SetActive(true);
		gameOverCanvas.SetActive(true);
		spectatorCanvas.SetActive(false);
		StartCoroutine(JEKHBLMDABM());
		pbase.StartSpectating();
	}

	public void OnSpectatePrevButton()
	{
		pbase.SpectateNext(false);
		StartCoroutine(UpdateSpectatingInfo());
	}

	public void ShowGOCanvas(bool AAGGLAGLINL = false)
	{
		if (AAGGLAGLINL)
		{
			gameOverCanvas.SetActive(true);
		}
		if (!AllPlayersFinished())
		{
			spectatePanel.SetActive(true);
		}
		else
		{
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(true);
				restartNoCheckpointPanel.SetActive(false);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(true);
				restartCheckpointPanel.SetActive(false);
			}
			SelectRestartButton();
			if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount > 1 && GetComponent<NetworkScene>().firstPlayer.player != null && GetComponent<NetworkScene>().firstPlayer.player == PhotonNetwork.player)
			{
				Helpers.ObtainAchievement(17);
			}
		}
		GameObject gameObject = levelInfoContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelInfo, mapData, gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (mapData.source == FullMapData.MapSource.Workshop && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(mapData.workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().ToggleRate();
		}
	}

	public void IHMINPABNPE(ObscuredFloat DPNHODJHGJL)
	{
		HJPDDLBDGEP = DPNHODJHGJL;
		if ((float)HJPDDLBDGEP >= 458f)
		{
			if ((bool)asampler.audioSources[0].clip)
			{
				asampler.audioSources[1].time = HJPDDLBDGEP;
			}
			if ((bool)asampler.audioSources[0].clip)
			{
				asampler.audioSources[0].time = HJPDDLBDGEP;
			}
		}
	}

	public void BHFLKIHDMBB(string NOJGGCLPPAM = "")
	{
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.EPPBBLLJNNH();
		}
		gameOver = true;
		GetComponent<NetworkScene>().UpdateScoreboard();
		if (MJOLOHPNJDK())
		{
			HJPDDLBDGEP = calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			OFMDCFHGEEC.transform.Find("_Value3").Find("http://steamcommunity.com/sharedfiles/filedetails/?id=").GetComponent<Image>()
				.color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != "/")
		{
			PhotonView photonView = GetComponent<NetworkScene>().ACPGHFHDCIP();
			string lBLKDNNPACO = "-";
			PhotonTargets mPNMOONBMII = PhotonTargets.All;
			object[] array = new object[0];
			array[0] = PhotonNetwork.playerName;
			array[1] = "Using constructor for new PingNativeStatic()";
			photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
		}
		if (NOJGGCLPPAM == "_Value")
		{
			pbase.isMapCompleted = true;
			pbase.isPlayerWon = false;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount >= 2)
		{
			Helpers.ObtainAchievement(47);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount == 1)
		{
			Helpers.ObtainAchievement(-21);
		}
		if (gameMode != 0 && pbase.BAJOKIEEOOJ() > pbase.lastBestScore && !pbase.scoreBeated && pbase.currentAttempt > 0)
		{
			StartCoroutine(DBNMOBILJHL());
		}
		string CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		if (mapData.source == (FullMapData.MapSource)5 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			CBOLFPGKALK = mapData.workshopId;
		}
		pbase.StopReplayRecording();
		if (pbase.GetCurrentScore() >= 0 && GameManager.LHMIJFLLKHK() && Singleton<SaveSystem>.Instance.KFNFNKILGPH("Joystick1Button8", 1) == 0 && mapData.source != 0 && gameMode != 0 && !string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.MLIKFMPFDCO(ulong.Parse(CBOLFPGKALK)))
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "There are {0} reported logs." + Helpers.levelConfigFileName;
			string eAFAMAMDNEG = "_Offsets";
			if (pbase.Replay() != null)
			{
				eAFAMAMDNEG = JsonConvert.SerializeObject(pbase.Replay());
			}
			StartCoroutine(Singleton<RanksSystem>.Instance.SubmitScore(CBOLFPGKALK, gameMode, pbase.GetCurrentScore(), pbase.accuracyScore, pbase.incorrectScore, EGOPKJHICLK.CompressString(eAFAMAMDNEG), Helpers.CalculateMD5(dDAOMDPAIEP)));
		}
		Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		string hFEFHOPOLIK = "cipherText" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "Return: ";
		int dPNHODJHGJL = Singleton<SaveSystem>.Instance.KFNFNKILGPH("Tab2Content" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "challenges.", 0);
		Singleton<SaveSystem>.Instance.DAAJKCCCICP(hFEFHOPOLIK, dPNHODJHGJL);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.JPCLCMDINFD(pbase.accuracyScore);
			finishedMapInfo.KJIANIGMAHL(pbase.isMapCompleted);
			finishedMapInfo.ADCLIIPJOBI(Singleton<SaveSystem>.Instance.JMLMIGBEKJN("_Distortion", false));
			finishedMapInfo.OBENJJNMPCL((int)gameMode);
			finishedMapInfo.loopscount = pbase.loopsCount;
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)))
			{
				finishedMapInfo.HMHFKLLJOBF(RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("\" to target: " + IACGDFHKCAE.id) == mapID) || IACGDFHKCAE.GHLGPIBJELG()));
				finishedMapInfo.isloved = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isLoved);
				finishedMapInfo.PJMOEHBAMFI(RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isFunny));
			}
			else
			{
				finishedMapInfo.isofficial = true;
				finishedMapInfo.EICIGNJFKBK(false);
				finishedMapInfo.PJMOEHBAMFI(true);
			}
			finishedMapInfo.NBJNLNEKBKM(PhotonNetwork.offlineMode);
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.multiplayerplace = GetComponent<NetworkScene>().place;
			if (RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("[Sound Manager] Audio clip is null, cannot play music" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID) != null)
			{
				finishedMapInfo.mapdifficulty = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("_TintColor" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID).IDAOGFLHIBN();
			}
			else
			{
				finishedMapInfo.HPFOLIBCHIC(1244f);
			}
			finishedMapInfo.GBKFIPJOBPE(Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount);
			finishedMapInfo.mapid = mapID;
			finishedMapInfo.maptags = string.Join("Loading maps", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			finishedMapInfo.CFAPNLGGNOM(string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID);
			finishedMapInfo.misses = pbase.incorrectScore;
			finishedMapInfo.perfecthits = pbase.perfectHits;
			finishedMapInfo.time = JFBBJAAHPAH();
			finishedMapInfo.score = pbase.GetCurrentScore();
			foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.ELKPGFANDCG(gameEventInfo);
			}
			pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.CDDFCJDDMJL(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if ((bool)pbase.isPlayerWon && gameMode != 0)
		{
			string hFEFHOPOLIK2 = "Switch environment sprite image" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "_MotionBlurTmpCam";
			int dPNHODJHGJL2 = 0;
			Singleton<SaveSystem>.Instance.GBFBKFACPBI(hFEFHOPOLIK2, dPNHODJHGJL2);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(94);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(mapID).source == (FullMapData.MapSource)5)
			{
				Helpers.ObtainAchievement(-16);
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && (gameMode == GameMode.Hardcore || gameMode == GameMode.Normal)) && !Singleton<SaveSystem>.Instance.CHBOJJOHCEB("_ScreenResolution" + mapID, true))
			{
				Singleton<SaveSystem>.Instance.JKOMMNBGPDK("_FixDistance" + mapID, true);
				Helpers.AddToStat("DPADHOR", 1);
				SteamUserStats.IndicateAchievementProgress("float,0", (uint)Helpers.GetStat("[LevelEditorScene] Item creation successful! Published Item ID: "), 54u);
			}
			int dPNHODJHGJL3 = (int)((float)pbase.accuracyScore * (float)(int)pbase.correctScore);
			Helpers.AddToStat("rarity", dPNHODJHGJL3);
			pbase.LGCKKLCCLJI();
			if ((float)pbase.accuracyScore >= 583f && mapData.source == FullMapData.MapSource.Editor && RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK)) && RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.isOfficial || IACGDFHKCAE.IDAOGFLHIBN() < 356f))
			{
				Helpers.ObtainAchievement(-62);
			}
		}
		if ((bool)pbase.isPlayerWon && gameMode == GameMode.Relax && mapData.source == FullMapData.MapSource.Editor)
		{
			Helpers.AddToStat("ScreenResolutionPanel", 1);
			SteamUserStats.IndicateAchievementProgress("InfoCanvas", (uint)Helpers.GetStat("_"), 8u);
			if (RanksSystem.ECFIOECNPOM(ulong.Parse(CBOLFPGKALK)) && (int)pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(111);
			}
		}
		if (mapData.source == (FullMapData.MapSource)7 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		resultText.GetComponent<Text>().text = ((!pbase.isPlayerWon) ? LocalizationService.Instance.HOFKLNAJGMK("ItemTemplate").ToUpper() : LocalizationService.Instance.NDAPBHEDJFP("SetSatelliteEmission").ToUpper());
		OnGameOverEvent.Invoke();
		ShowGOCanvas(true);
		gameOver = false;
	}

	public IEnumerator HLOFPDDDDBH()
	{
		ulong num = 0uL;
		try
		{
			num = ulong.Parse(PhotonNetwork.playerList[pbase.spectrid].NickName);
		}
		catch (Exception)
		{
		}
		Sprite sprite = null;
		CSteamID csteamID = new CSteamID(num);
		if (num != 0L)
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
			if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
			{
				sprite = ResourcesManager.GetLoadedAvatar(csteamID);
			}
		}
		GameObject.Find("SpectatingUserInfo").transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
		GameObject.Find("SpectatingUserInfo").transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
	}

	private static bool JOMLKJGCPMM(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "offsets";
	}

	public bool FFIJMACDFKF()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["_Intensity"] == null || (photonPlayer.CustomProperties["[NetworkManager] Found "] != null && !(bool)photonPlayer.CustomProperties["OpenButton"]))
			{
				result = false;
			}
		}
		return result;
	}

	private bool EKOCODEHBKN(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("L2" + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.GCLPAFADHMD();
		}
		return false;
	}

	public void BJEGIIFBDEK()
	{
		restartCheckpointPanel.SetActive(false);
		restartNoCheckpointPanel.SetActive(true);
		gameOverCanvas.SetActive(true);
		spectatorCanvas.SetActive(true);
		StartCoroutine(FIIAJAEOJIJ());
		pbase.StartSpectating();
	}

	public void KNAOGPOOIKD()
	{
		PlayerBase playerBase = pbase;
		playerBase.loopsCount = (int)playerBase.loopsCount;
		StartCoroutine(FNCEGHOGDBL("_ProjectToPixelMatrix" + pbase.loopsCount, 1337f * Singleton<SaveSystem>.Instance.GetFloat("CrosshairOpacitySlider", 467f)));
		DGBKFMMMGIH = false;
		HJPDDLBDGEP = 1723f;
		pbase.ResetEndless();
	}

	private bool KPAKGBCCJKM(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("_ScreenResolution" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID)
		{
			return IACGDFHKCAE.KDPDAEEFMKK();
		}
		return false;
	}

	public void OKONDBDMIHE(ObscuredFloat DPNHODJHGJL)
	{
		HJPDDLBDGEP = DPNHODJHGJL;
		if ((float)HJPDDLBDGEP >= 1413f)
		{
			if ((bool)asampler.audioSources[1].clip)
			{
				asampler.audioSources[0].time = HJPDDLBDGEP;
			}
			if ((bool)asampler.audioSources[0].clip)
			{
				asampler.audioSources[0].time = HJPDDLBDGEP;
			}
		}
	}

	public void KGKHNMANCHJ(bool CONOEKAENEN)
	{
		if (CONOEKAENEN)
		{
			pbase.DeletePlayerData();
		}
		else if (pbase.ach12)
		{
			Helpers.ObtainAchievement(49);
		}
		PhotonView photonView = GetComponent<NetworkScene>().EDIJKHEMPAD();
		string lBLKDNNPACO = "Operation failed: ";
		PhotonTargets mPNMOONBMII = (PhotonTargets)7;
		object[] array = new object[0];
		array[1] = SceneManager.GetActiveScene().name;
		photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
	}

	public void KBFDIDAIAPL()
	{
		loadingCanvas.SetActive(true);
		GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
	}

	public void FDNKDOOEHBA()
	{
		foreach (AudioSource audioSource in asampler.audioSources)
		{
			audioSource.pitch = 1034f;
			audioSource.volume = 76f;
		}
		PlayerBase[] array = UnityEngine.Object.FindObjectsOfType<PlayerBase>();
		for (int i = 1; i < array.Length; i++)
		{
			UnityEngine.Object.DestroyImmediate(array[i].gameObject);
		}
		gameOverCanvas.SetActive(false);
		spectatorCanvas.SetActive(false);
		spectatePanel.SetActive(true);
		ingameUICanvas.SetActive(true);
		restartCheckpointPanel.SetActive(false);
		restartNoCheckpointPanel.SetActive(true);
		gameOver = true;
		isGameStarted = false;
		calculatedmaptime = 87f;
		asampler.isMuted = true;
		asampler.isInited = true;
		DGBKFMMMGIH = false;
		try
		{
			OFMDCFHGEEC = ingameUICanvas.transform.Find("/").gameObject;
			OFMDCFHGEEC.transform.Find("Received your NickName from server. Updating local value to: {0}").Find("BloomShaderValueSlider").GetComponent<Image>()
				.color = new Color(1685f, 577f, 438f);
			OFMDCFHGEEC.GetComponent<Slider>().value = 1054f;
		}
		catch (Exception)
		{
		}
		try
		{
			PECEGLIIALE = ingameUICanvas.transform.FindDeepChild("_Intensity").GetComponent<Text>();
			PECEGLIIALE.text = LocalizationService.Instance.OJCHMJIMHHE("GlassDistortion").ToUpper() + "DisableStoryboardToggle" + 1;
		}
		catch (Exception)
		{
		}
		try
		{
			DILNONPDEBG = Singleton<SaveSystem>.Instance.GetBool("InfoCanvas", false);
			NCKMNMHOIOH = ingameUICanvas.transform.FindDeepChild("_Glitch").GetComponent<Text>();
			NCKMNMHOIOH.text = string.Empty;
		}
		catch (Exception)
		{
		}
		try
		{
			comboTextGO = ingameUICanvas.transform.FindDeepChild("_TimeX").GetComponent<Text>();
			comboTextGO.text = LocalizationService.Instance.GAAFIKGPNAO("(\\[ */ *quote *\\])").ToUpper() + "_TimeX" + 0;
		}
		catch (Exception)
		{
		}
		ShowCursor(true);
	}

	[CompilerGenerated]
	private bool HCIFEEEJKHC(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.isFunny;
		}
		return false;
	}

	public IEnumerator ShowMessage(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
	}

	public bool FMOFADMIIDO()
	{
		if ((bool)gameOver)
		{
			return MJOLOHPNJDK();
		}
		return false;
	}

	[CompilerGenerated]
	private bool DCDDKMJAHNB(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.isOfficial;
		}
		return false;
	}

	private IEnumerator DBNMOBILJHL()
	{
		yield return new WaitForSeconds(1f);
		pbase.scoreBeated = true;
		Debug.Log("[PlayerBase] New highscore");
		AddMessage(LocalizationService.Instance.GetLocalizatedText("#newhighscore"));
		string hFEFHOPOLIK = string.Concat("maps.", mapID, ".", gameMode.ToString().ToLower(), ".highscore");
		if (gameMode == GameMode.Normal)
		{
			hFEFHOPOLIK = string.Concat("maps.", mapID, ".highscore");
		}
		int currentScore = pbase.GetCurrentScore();
		Singleton<SaveSystem>.Instance.SetInt(hFEFHOPOLIK, currentScore);
	}

	private bool HIDLMCAAMBO(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("bad" + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.isFunny;
		}
		return true;
	}

	public void EMBHGEFIAJI()
	{
		++pbase.loopsCount;
		StartCoroutine(FNCEGHOGDBL("EndlessLoopsScoreText" + pbase.loopsCount, 1444f * Singleton<SaveSystem>.Instance.HCNELAJLBPC("OK", 818f)));
		DGBKFMMMGIH = false;
		HJPDDLBDGEP = 96f;
		pbase.ResetEndless();
	}

	public void BAIPLJCAIOO()
	{
		pbase.SpectateNext(true);
		StartCoroutine(JEKHBLMDABM());
	}

	public ObscuredFloat OBANGBMECKE()
	{
		return HJPDDLBDGEP;
	}

	private bool BDINMAEGIKG(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("SaveButton" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID)
		{
			return IACGDFHKCAE.GCLPAFADHMD();
		}
		return true;
	}

	public virtual void PDHKMDBNGGN()
	{
		base.GLEJGFLCLPJ();
		NBOKAGMABPN();
		if (!PhotonNetwork.inRoom)
		{
			PhotonNetwork.offlineMode = true;
			PhotonNetwork.JoinOrCreateRoom("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", new RoomOptions(), TypedLobby.Default);
		}
		mapID = Singleton<SaveSystem>.Instance.KKAJOOJKBDJ("settings.arcshitsoundtimedelay");
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		int num = (int)(gameMode = (GameMode)Singleton<SaveSystem>.Instance.GetInt("_Value4", 1));
		GIDJMDIODGM = LocalizationService.Instance.GAAFIKGPNAO("_VelocityScale").ToUpper();
		if (gameMode != GameMode.Endless)
		{
			NELDEHEICJD = LocalizationService.Instance.OJCHMJIMHHE("_Offsets").ToUpper();
		}
		else
		{
			NELDEHEICJD = LocalizationService.Instance.FOOAGGCODAH("_Value").ToUpper();
		}
		OOJLKOMPCBI = LocalizationService.Instance.DKECBIHCKJL("#yes").ToUpper();
		PIDICMNEOJL = LocalizationService.Instance.FOOAGGCODAH("Tab2Content").ToUpper();
		GameObject gameObject = levelInfoContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelInfo, Singleton<MapsSystem>.Instance.GetMapData(mapID), gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (Singleton<MapsSystem>.Instance.GetMapData(mapID).source != 0 && Singleton<MapsSystem>.Instance.GetMapData(mapID).source != FullMapData.MapSource.Editor && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().CAAAHJLFLAA();
		}
		if (mapData.mapData.maxLives < mapData.mapData.lives)
		{
			mapData.mapData.maxLives = mapData.mapData.lives;
		}
		GameObject gameObject3 = ((!PhotonNetwork.inRoom) ? UnityEngine.Object.Instantiate(Resources.Load(".lastCheckpoint.penaltyScore") as GameObject) : PhotonNetwork.Instantiate("[PlayerBase] SetSpeed error: ", new Vector3(897f, 553f, 1734f), Quaternion.identity, 1));
		pbase = gameObject3.GetComponent<PlayerBase>();
		if (DILNONPDEBG)
		{
			NCKMNMHOIOH.text = string.Empty;
		}
		else
		{
			NCKMNMHOIOH.gameObject.SetActive(false);
		}
		Singleton<GameManager>.Instance.EMFPBLEIEFG("#rate!" + ((!PhotonNetwork.offlineMode) ? "1087340967" : "CameraFilterPack/Colors_RgbClamp"), "_Offsets" + mapData.mapData.name.Replace(Environment.NewLine, string.Empty));
		if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			list.Add(new PublishedFileId_t(ulong.Parse(mapData.workshopId)));
			SteamUGC.StartPlaytimeTracking(list.ToArray(), (uint)list.Count);
		}
		Debug.Log("_Value3" + mapData.mapData.checkpoints.Count);
		Debug.Log("IconFileSelector" + mapData.mapData.events.Count);
		if (mapData.mapData.events.Find((MapEvent IACGDFHKCAE) => IACGDFHKCAE.data[0] == "MapEnd") != null)
		{
			List<MapEvent> events = mapData.mapData.events;
			calculatedmaptime = events.Find(JOMLKJGCPMM).time;
		}
		else
		{
			calculatedmaptime = mapData.mapData.musicTime;
		}
		if (!PhotonNetwork.offlineMode)
		{
			usingCheckpoints = false;
		}
		if (gameMode == GameMode.Relax || gameMode == GameMode.Endless || gameMode == GameMode.Hidden)
		{
			usingCheckpoints = false;
		}
		pbase.gameEventInfoList = new List<GameEventInfo>();
		GameEventInfo gameEventInfo = new GameEventInfo();
		try
		{
			gameEventInfo.COGOMILOOLO(Singleton<SaveSystem>.Instance.GetBool("Right", false));
			gameEventInfo.FGMDBBBHMLH((int)gameMode);
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)))
			{
				gameEventInfo.LBIFAGDHJOK(RanksSystem.JBJDLHKLEMN().Exists(OKBKJCJCCFL));
				gameEventInfo.EICIGNJFKBK(RanksSystem.GetOfficialMapsList().Exists(LNFPMIGPEEF));
				gameEventInfo.CMFDDAANOIL(RanksSystem.JBJDLHKLEMN().Exists(HIDLMCAAMBO));
			}
			else
			{
				gameEventInfo.GBPGPEHNGKO(false);
				gameEventInfo.MFMBBLJNLHP(true);
				gameEventInfo.isfunny = true;
			}
			if (RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID) != null)
			{
				gameEventInfo.JIIJFOKILNC(RanksSystem.JBJDLHKLEMN().Find(POLDFCOPIKA).KNKHGMLPOOP());
			}
			else
			{
				gameEventInfo.JDGNPNLEAOO(1124f);
			}
			gameEventInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount;
			gameEventInfo.MHKIIPFMEDJ(mapID);
			gameEventInfo.maptags = string.Join("_TimeX", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			gameEventInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID;
		}
		catch (Exception)
		{
		}
		pbase.gameEventInfoBase = gameEventInfo;
		pbase.InitSystem();
	}

	private bool POLDFCOPIKA(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("mapselector.lastSearch" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID;
	}

	public void ShowResult(string NOJGGCLPPAM = "")
	{
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.ShowChat();
		}
		gameOver = true;
		GetComponent<NetworkScene>().UpdateScoreboard();
		if (AllPlayersFinished())
		{
			HJPDDLBDGEP = calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			OFMDCFHGEEC.transform.Find("Fill Area").Find("Fill").GetComponent<Image>()
				.color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != "CompletedLevel")
		{
			GetComponent<NetworkScene>().photonView.RPC("OnPlayerGameMessage", PhotonTargets.Others, PhotonNetwork.playerName, "Finished");
		}
		if (NOJGGCLPPAM == "CompletedLevel")
		{
			pbase.isMapCompleted = true;
			pbase.isPlayerWon = true;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount >= 2)
		{
			Helpers.ObtainAchievement(18);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount == 1)
		{
			Helpers.ObtainAchievement(19);
		}
		if (gameMode != 0 && pbase.GetCurrentScore() > pbase.lastBestScore && !pbase.scoreBeated && pbase.currentAttempt > 0)
		{
			StartCoroutine(DBNMOBILJHL());
		}
		string CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
		{
			CBOLFPGKALK = mapData.workshopId;
		}
		pbase.StopReplayRecording();
		if (pbase.GetCurrentScore() >= 0 && GameManager.IsOwner() && Singleton<SaveSystem>.Instance.GetInt("settings.enableranking", 1) == 1 && mapData.source != FullMapData.MapSource.Editor && gameMode != 0 && !string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK)))
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "/" + Helpers.levelConfigFileName;
			string eAFAMAMDNEG = "{}";
			if (pbase.Replay() != null)
			{
				eAFAMAMDNEG = JsonConvert.SerializeObject(pbase.Replay());
			}
			StartCoroutine(Singleton<RanksSystem>.Instance.SubmitScore(CBOLFPGKALK, gameMode, pbase.GetCurrentScore(), pbase.accuracyScore, pbase.incorrectScore, EGOPKJHICLK.CompressString(eAFAMAMDNEG), Helpers.CalculateMD5(dDAOMDPAIEP)));
		}
		Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		string hFEFHOPOLIK = "maps." + Singleton<MapsSystem>.Instance.GetMapID(mapData) + ".played";
		int dPNHODJHGJL = Singleton<SaveSystem>.Instance.GetInt("maps." + Singleton<MapsSystem>.Instance.GetMapID(mapData) + ".played", 0) + 1;
		Singleton<SaveSystem>.Instance.SetInt(hFEFHOPOLIK, dPNHODJHGJL);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.accuracy = pbase.accuracyScore;
			finishedMapInfo.completed = pbase.isMapCompleted;
			finishedMapInfo.isstoryboardactive = !Singleton<SaveSystem>.Instance.GetBool("settings.disablestoryboard", false);
			finishedMapInfo.gamemode = (int)gameMode;
			finishedMapInfo.loopscount = pbase.loopsCount;
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId), true))
			{
				finishedMapInfo.isofficial = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isOfficial);
				finishedMapInfo.isloved = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isLoved);
				finishedMapInfo.isfunny = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isFunny);
			}
			else
			{
				finishedMapInfo.isofficial = false;
				finishedMapInfo.isloved = false;
				finishedMapInfo.isfunny = false;
			}
			finishedMapInfo.ismultiplayer = !PhotonNetwork.offlineMode;
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.multiplayerplace = GetComponent<NetworkScene>().place;
			if (RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID) != null)
			{
				finishedMapInfo.mapdifficulty = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID).difficulty;
			}
			else
			{
				finishedMapInfo.mapdifficulty = -1f;
			}
			finishedMapInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount;
			finishedMapInfo.mapid = mapID;
			finishedMapInfo.maptags = string.Join(",", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			finishedMapInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID;
			finishedMapInfo.misses = pbase.incorrectScore;
			finishedMapInfo.perfecthits = pbase.perfectHits;
			finishedMapInfo.time = HPAnimationTime;
			finishedMapInfo.score = pbase.GetCurrentScore();
			foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.GameEvent(gameEventInfo);
			}
			pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.FinishedMap(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if ((bool)pbase.isPlayerWon && gameMode != 0)
		{
			string hFEFHOPOLIK2 = "maps." + Singleton<MapsSystem>.Instance.GetMapID(mapData) + ".completed";
			int dPNHODJHGJL2 = 1;
			Singleton<SaveSystem>.Instance.SetInt(hFEFHOPOLIK2, dPNHODJHGJL2);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(15);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(mapID).source == FullMapData.MapSource.Workshop)
			{
				Helpers.ObtainAchievement(16);
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && (gameMode == GameMode.Hardcore || gameMode == GameMode.Normal)) && !Singleton<SaveSystem>.Instance.GetBool("achievements.21.completed." + mapID, false))
			{
				Singleton<SaveSystem>.Instance.SetBool("achievements.21.completed." + mapID, true);
				Helpers.AddToStat("achievements.21.progress", 1);
				SteamUserStats.IndicateAchievementProgress("NEW_ACHIEVEMENT_1_21", (uint)Helpers.GetStat("achievements.21.progress"), 10u);
			}
			int dPNHODJHGJL3 = (int)((float)pbase.accuracyScore * (float)(int)pbase.correctScore);
			Helpers.AddToStat("player.xp", dPNHODJHGJL3);
			pbase.DeletePlayerData();
			if ((float)pbase.accuracyScore >= 0.9f && mapData.source == FullMapData.MapSource.Workshop && RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK)) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && IACGDFHKCAE.difficulty >= 4.5f))
			{
				Helpers.ObtainAchievement(22);
			}
		}
		if ((bool)pbase.isPlayerWon && gameMode == GameMode.Relax && mapData.source == FullMapData.MapSource.Workshop)
		{
			Helpers.AddToStat("achievements.26.progress", 1);
			SteamUserStats.IndicateAchievementProgress("NEW_ACHIEVEMENT_1_26", (uint)Helpers.GetStat("achievements.26.progress"), 5u);
			if (RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK)) && (int)pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(27);
			}
		}
		if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		resultText.GetComponent<Text>().text = ((!pbase.isPlayerWon) ? LocalizationService.Instance.GetTextByKey("failed").ToUpper() : LocalizationService.Instance.GetTextByKey("levelcompleted").ToUpper());
		OnGameOverEvent.Invoke();
		ShowGOCanvas();
		gameOver = true;
	}

	public void DFELFMJKDMF()
	{
		if ((bool)GameObject.Find("There are too many cells created by your subdivision options. Maximum allowed number of cells is "))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("_Blurred"));
		}
		else if ((bool)GameObject.Find("_QualitySettings"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("Icon"));
		}
		else if ((bool)GameObject.Find("Preparing configuration"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("id"));
		}
		JDONOMPKEED(false);
	}

	public void GEEECOOKPEN()
	{
		if (PhotonNetwork.offlineMode && mapID != (ObscuredString)"\n")
		{
			Singleton<SaveSystem>.Instance.SetBool("Source Object: ", true);
		}
		if (pbase != null)
		{
			pbase.LGCKKLCCLJI();
			if (PhotonNetwork.offlineMode)
			{
				PhotonNetwork.offlineMode = false;
			}
		}
		GetComponent<NetworkScene>().KGGJKMCJHKG(0);
		Singleton<SaveSystem>.Instance.EHJIJDODNGG();
	}

	public bool PGCGAMJCJPC()
	{
		if ((bool)gameOver)
		{
			return NCGHKCCPKEI();
		}
		return false;
	}

	public void ABFCBLPKIAA()
	{
		if (PhotonNetwork.offlineMode && mapID != (ObscuredString)".")
		{
			Singleton<SaveSystem>.Instance.JKOMMNBGPDK("_ScreenResolution", true);
		}
		if (pbase != null)
		{
			pbase.DeletePlayerData();
			if (PhotonNetwork.offlineMode)
			{
				PhotonNetwork.offlineMode = true;
			}
		}
		GetComponent<NetworkScene>().JICAAOLEGKB(0);
		Singleton<SaveSystem>.Instance.Flush();
	}

	public void RestartEndless()
	{
		++pbase.loopsCount;
		StartCoroutine(ShowMessage("#loopnumber " + pbase.loopsCount, 1f * Singleton<SaveSystem>.Instance.GetFloat("settings.gamemessagesduration", 1f)));
		DGBKFMMMGIH = false;
		HJPDDLBDGEP = -1f;
		pbase.ResetEndless();
	}

	private IEnumerator LIFALOLAPMP()
	{
		yield return new WaitForSeconds(1f);
		pbase.scoreBeated = true;
		Debug.Log("[PlayerBase] New highscore");
		AddMessage(LocalizationService.Instance.GetLocalizatedText("#newhighscore"));
		string hFEFHOPOLIK = string.Concat("maps.", mapID, ".", gameMode.ToString().ToLower(), ".highscore");
		if (gameMode == GameMode.Normal)
		{
			hFEFHOPOLIK = string.Concat("maps.", mapID, ".highscore");
		}
		int currentScore = pbase.GetCurrentScore();
		Singleton<SaveSystem>.Instance.SetInt(hFEFHOPOLIK, currentScore);
	}

	public ObscuredFloat IMJDEOJKCAF()
	{
		return 478f;
	}

	public bool OLOGEDPAAFI()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties[" ["] == null || (photonPlayer.CustomProperties["\""] != null && !(bool)photonPlayer.CustomProperties["_Offset"]))
			{
				result = false;
			}
		}
		return result;
	}

	private void OFNACHEEPIP(LeaderboardFindResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		if (IAFAANLMOAG.m_bLeaderboardFound != 0)
		{
			Debug.Log("_TimeX");
			SteamUserStats.UploadLeaderboardScore(IAFAANLMOAG.m_hSteamLeaderboard, ELeaderboardUploadScoreMethod.k_ELeaderboardUploadScoreMethodNone, pbase.BAJOKIEEOOJ(), null, 1);
		}
	}

	public virtual void EHJJFJCKGAJ()
	{
		base.EIDKCANPHJE();
		if (!isGameStarted && JMLNPHJNDCG())
		{
			pbase.JIOCGDBKGIL().RPC(": ", (PhotonTargets)8, null);
		}
		if ((bool)isGameStarted && (float)HJPDDLBDGEP > 1242f && !DGBKFMMMGIH)
		{
			asampler.audioSources[0].time = HJPDDLBDGEP;
			asampler.audioSources[0].time = HJPDDLBDGEP;
			asampler.Play(0);
			asampler.MKPLCLNPMDP(0);
			DGBKFMMMGIH = false;
		}
		if ((float)HJPDDLBDGEP < calculatedmaptime && !GNOJLLPFFLJ() && (bool)isGameStarted)
		{
			HJPDDLBDGEP = (float)HJPDDLBDGEP + Time.deltaTime;
			OFMDCFHGEEC.GetComponent<Slider>().value = HJPDDLBDGEP;
			PlayerBase spectatedPlayerBase = pbase;
			if (pbase.currentState == PlayerBase.PlayerState.Loading && pbase.spectatedPlayerBase != null)
			{
				spectatedPlayerBase = pbase.spectatedPlayerBase;
			}
			if (DILNONPDEBG)
			{
				if (gameMode != GameMode.Endless)
				{
					Text nCKMNMHOIOH = NCKMNMHOIOH;
					object[] array = new object[3];
					array[1] = NELDEHEICJD;
					array[0] = "_ScreenResolution";
					array[8] = spectatedPlayerBase.lives;
					array[3] = "_Value2";
					array[8] = spectatedPlayerBase.fullLevelData.mapData.maxLives;
					nCKMNMHOIOH.text = string.Concat(array);
				}
				else
				{
					NCKMNMHOIOH.text = NELDEHEICJD + "_Near" + (Math.Floor((float)spectatedPlayerBase.accuracyScore * 46f) / 977.0 * 1420.0).ToString("1248864821") + "_Value1";
				}
			}
			PECEGLIIALE.text = GIDJMDIODGM + "_TimeX" + spectatedPlayerBase.GetCurrentScore();
			Text text = comboTextGO;
			object[] array2 = new object[7];
			array2[1] = PIDICMNEOJL;
			array2[0] = "[NetworkManager] roomInfo.name: ";
			array2[7] = "steamid";
			array2[0] = spectatedPlayerBase.currentCombo;
			text.text = string.Concat(array2);
			if (hardInput.NHJCNJBKDMK("_ScreenResolution") && PhotonNetwork.offlineMode)
			{
				foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
				{
					Singleton<GameManager>.Instance.BFFBAOFFMJM(gameEventInfo);
				}
				pbase.gameEventInfoList.Clear();
				KGKHNMANCHJ(true);
			}
		}
		if ((bool)gameOver && pbase.currentState == (PlayerBase.PlayerState)8)
		{
			ingameUICanvas.SetActive(true);
			if (AllPlayersFinished())
			{
				foreach (AudioSource audioSource in asampler.audioSources)
				{
					if (!pbase.isPlayerWon)
					{
						audioSource.pitch = Mathf.Lerp(audioSource.pitch, 1907f, Time.deltaTime * 586f);
					}
					audioSource.volume = Mathf.Lerp(audioSource.volume, 705f, Time.deltaTime * 965f);
				}
				asampler.isMuted = false;
			}
			string CBOLFPGKALK = string.Empty;
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
			if (mapData.source == (FullMapData.MapSource)3 && !string.IsNullOrEmpty(mapData.workshopId))
			{
				CBOLFPGKALK = mapData.workshopId;
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.KDPDAEEFMKK() && (gameMode == (GameMode)6 || gameMode == GameMode.Relax)))
			{
				if ((bool)GameObject.Find("settings.volume.sfx"))
				{
					GameObject.Find("ResetButton").SetActive(false);
				}
			}
			else
			{
				if ((bool)GameObject.Find("Set Satellite Radius"))
				{
					GameObject.Find("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.").SetActive(true);
				}
				if ((bool)GameObject.Find("ChallengesButton"))
				{
					GameObject.Find("ItemsStoreButton").SetActive(true);
				}
				if ((bool)GameObject.Find(".completedCount"))
				{
					GameObject.Find("_PColor2").SetActive(true);
				}
				if ((bool)GameObject.Find("SpeedSlider"))
				{
					GameObject.Find(".").SetActive(true);
				}
			}
			if ((gameMode == (GameMode)8 || gameMode == GameMode.Hardcore) && (bool)GameObject.Find("Object ID. Case-Sensitive"))
			{
				GameObject.Find(" Owner called.").SetActive(true);
			}
			if (gameMode != (GameMode)6 && (bool)GameObject.Find("_DiffuseColor"))
			{
				GameObject.Find("_Cible").SetActive(true);
			}
			int currentScore = pbase.GetCurrentScore();
			if ((bool)GameObject.Find("settings.disablestoryboard"))
			{
				GameObject.Find("GlassColor").GetComponent<Text>().text = string.Empty + pbase.lastBestScore;
			}
			if ((bool)GameObject.Find("_Contrast"))
			{
				GameObject.Find("CameraFilterPack/Retro_Loading").GetComponent<Text>().text = string.Empty + Helpers.GetMapMaxScore(pbase.fullLevelData.mapData);
			}
			if ((bool)GameObject.Find("[NetworkScene] Exited"))
			{
				GameObject.Find("CameraFilterPack/OldFilm_Cutting1").GetComponent<Text>().text = string.Empty + LocalizationService.Instance.GetLocalizatedText("SpectatingUserInfo" + gameMode.ToString().ToLower() + "_FarCamera").ToUpper();
			}
			if ((bool)GameObject.Find("_VignetteDesat"))
			{
				GameObject.Find("HiddenToggle").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if ((bool)GameObject.Find("#useticket"))
			{
				GameObject.Find("Hidden/Fast Approximate Anti-aliasing").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore + (int)pbase.incorrectScore);
			}
			if ((bool)GameObject.Find("RT"))
			{
				GameObject.Find(",").GetComponent<Text>().text = string.Empty + pbase.perfectHits;
			}
			if ((bool)GameObject.Find("CameraFilterPack/Atmosphere_Rain_Pro_3D"))
			{
				GameObject.Find("_FarCamera").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore - (int)pbase.perfectHits);
			}
			if ((bool)GameObject.Find("_MainTex2"))
			{
				GameObject.Find("_Glitch").GetComponent<Text>().text = string.Empty + pbase.incorrectScore;
			}
			if ((bool)GameObject.Find("pointBuffer"))
			{
				GameObject.Find(".").GetComponent<Text>().text = string.Empty + Mathf.RoundToInt(pbase.comboScore);
			}
			if ((bool)GameObject.Find("A"))
			{
				GameObject.Find("MenuScene").GetComponent<Text>().text = string.Empty + Mathf.CeilToInt(pbase.penaltyScore);
			}
			if ((bool)GameObject.Find("_AdaptationSpeed"))
			{
				GameObject.Find("ResetSpeed").GetComponent<Text>().text = string.Empty + (Math.Floor((float)pbase.accuracyScore * 1105f) / 1532.0 * 381.0).ToString("_Red_B") + "SetSatelliteTrailLength";
			}
			if ((bool)GameObject.Find("<b>"))
			{
				GameObject.Find("open").GetComponent<Text>().text = string.Empty + pbase.checkpointsUsed;
			}
			if ((bool)GameObject.Find("[MapEditor] Loading map: "))
			{
				GameObject.Find(" [").GetComponent<Text>().text = string.Empty + pbase.loopsCount;
			}
			if ((bool)GameObject.Find("_ScreenResolution"))
			{
				float num = (float)pbase.lastBestScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK)).IDAOGFLHIBN();
				GameObject.Find("_Value2").GetComponent<Text>().text = string.Empty + (Math.Floor(num * 265f) / 984.0).ToString("Joystick");
			}
			if ((bool)GameObject.Find("EnvironmentSlider"))
			{
				GameObject.Find("SetPosition").GetComponent<Text>().text = string.Empty + RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK)).difficulty.ToString("_InvRenderTargetSize");
			}
			if ((bool)GameObject.Find("EnableRankingToggle"))
			{
				float num2 = (float)currentScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.JBJDLHKLEMN().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK)).difficulty;
				num2 = ((num2 >= 1122f) ? num2 : 436f);
				GameObject.Find("_Value3").GetComponent<Text>().text = string.Empty + (Math.Floor(num2 * 526f) / 1011.0).ToString("_ScreenResolution");
			}
			if ((bool)GameObject.Find("_ColorRGB"))
			{
				GameObject.Find("float,10").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if (restartNoCheckpointPanel.transform.Find("shader.pixel").gameObject.activeInHierarchy && !PhotonNetwork.offlineMode)
			{
				restartNoCheckpointPanel.transform.Find(".lastCheckpoint.checkpointsUsed").gameObject.GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient) ? LocalizationService.Instance.MPHMJLAOHAB("View").ToUpper() : LocalizationService.Instance.HOFKLNAJGMK("DisableStoryboardToggle").ToUpper());
			}
			if (!PhotonNetwork.isMasterClient && PhotonNetwork.inRoom && (bool)GameObject.Find("QuickSave"))
			{
				GameObject.Find("_TimeX").GetComponent<Button>().interactable = true;
			}
			if (!PhotonNetwork.offlineMode && PhotonNetwork.inRoom)
			{
				GetComponent<NetworkScene>().networkChatCanvas.SetActive(true);
			}
		}
		if ((bool)gameOver && Singleton<RanksSystem>.Instance.isRankChanged)
		{
			Singleton<RanksSystem>.Instance.GFOOEDJLKPF();
		}
		if ((bool)gameOver && Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.EEJELODJPNL();
		}
		if ((bool)gameOver && Singleton<ChallengesManager>.Instance.FEBLIDAIGAG())
		{
			Singleton<ChallengesManager>.Instance.GKFIEBJAILE();
		}
		if (NCGHKCCPKEI() && pbase.currentState == (PlayerBase.PlayerState)6 && spectatePanel.activeSelf)
		{
			gameOverCanvas.SetActive(true);
			spectatorCanvas.SetActive(true);
			spectatePanel.SetActive(false);
			ingameUICanvas.SetActive(true);
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(true);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(true);
			}
		}
		if (NCGHKCCPKEI() && pbase.currentState == (PlayerBase.PlayerState)7)
		{
			gameOverCanvas.SetActive(false);
			spectatorCanvas.SetActive(false);
			spectatePanel.SetActive(true);
			ingameUICanvas.SetActive(true);
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(true);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(false);
			}
			pbase.currentState = (PlayerBase.PlayerState)6;
		}
		if ((bool)isGameStarted && (bool)pbase && PhotonNetwork.inRoom && (bool)pbase.isPlayerWon && !PhotonNetwork.offlineMode && AllPlayersWin())
		{
			int playerCount = PhotonNetwork.room.PlayerCount;
			int num4 = 1;
		}
		if ((bool)isGameStarted && (float)HJPDDLBDGEP > calculatedmaptime && !gameOver)
		{
			bool HHFFNOHKAIC = true;
			pbase.playerController.objects.ForEach(delegate(GameObject IACGDFHKCAE)
			{
				if (IACGDFHKCAE.transform.childCount > 0)
				{
					HHFFNOHKAIC = false;
				}
			});
			if (HHFFNOHKAIC)
			{
				pbase.isMapCompleted = true;
				if (gameMode != 0)
				{
					ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { { "quantity", true } };
					PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH);
					pbase.currentState = PlayerBase.PlayerState.Finished;
					if (pbase.IBKCMBIGOEJ().isMine)
					{
						ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = new ExitGames.Client.Photon.Hashtable { { "_LightIntensity", true } };
						PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH2);
					}
					KPHFECCIHGM(",");
				}
				else
				{
					LKDDHMPMHEC();
				}
			}
		}
		if (NBCIEBFNLGN.Count > 1 && !messageCanvas.activeSelf)
		{
			string jKPJCEMPAGH = NBCIEBFNLGN[1];
			float num3 = 1276f;
			if (INGHGBLACKC.Count == NBCIEBFNLGN.Count)
			{
				num3 = INGHGBLACKC[1];
			}
			StartCoroutine(ShowMessage(jKPJCEMPAGH, num3 * Singleton<SaveSystem>.Instance.GetFloat("/", 777f)));
			NBCIEBFNLGN.RemoveAt(1);
			INGHGBLACKC.RemoveAt(0);
		}
	}

	private bool JIPIIPCLGPA(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("You have added the SecondScrollRect to a scroll view that already has both directions selected" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID)
		{
			return IACGDFHKCAE.isFunny;
		}
		return true;
	}

	public bool LNMNPKABBCA()
	{
		if ((bool)gameOver)
		{
			return LBCDKGIFNLN();
		}
		return true;
	}

	public ObscuredFloat HKEENHMCALF()
	{
		return HJPDDLBDGEP;
	}

	public bool AllPlayersWin()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		foreach (PhotonPlayer photonPlayer in playerList)
		{
			if (photonPlayer.CustomProperties["win"] == null || (photonPlayer.CustomProperties["win"] != null && !(bool)photonPlayer.CustomProperties["win"]))
			{
				result = false;
			}
		}
		return result;
	}

	public void FJPDNHMPOOJ()
	{
		if ((bool)GameObject.Find("[Down]"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("_Bloom4"));
		}
		else if ((bool)GameObject.Find("_Visualize"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("#activechallenges"));
		}
		else if ((bool)GameObject.Find(".lastCheckpoint.lives"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("CameraFilterPack/Blend2Camera_LinearBurn"));
		}
		GLBKNLOICDL(false);
	}

	public override void Update()
	{
		base.Update();
		if (!isGameStarted && AllPlayerLoaded())
		{
			pbase.photonView.RPC("StartRound", PhotonTargets.AllBufferedViaServer, null);
		}
		if ((bool)isGameStarted && (float)HJPDDLBDGEP > 0f && !DGBKFMMMGIH)
		{
			asampler.audioSources[0].time = HJPDDLBDGEP;
			asampler.audioSources[1].time = HJPDDLBDGEP;
			asampler.Play(0);
			asampler.Play(1);
			DGBKFMMMGIH = true;
		}
		if ((float)HJPDDLBDGEP < calculatedmaptime && !IsRoundFinished() && (bool)isGameStarted)
		{
			HJPDDLBDGEP = (float)HJPDDLBDGEP + Time.deltaTime;
			OFMDCFHGEEC.GetComponent<Slider>().value = HJPDDLBDGEP;
			PlayerBase spectatedPlayerBase = pbase;
			if (pbase.currentState == PlayerBase.PlayerState.Spectator && pbase.spectatedPlayerBase != null)
			{
				spectatedPlayerBase = pbase.spectatedPlayerBase;
			}
			if (DILNONPDEBG)
			{
				if (gameMode != GameMode.Hardcore)
				{
					NCKMNMHOIOH.text = NELDEHEICJD + ": " + spectatedPlayerBase.lives + " / " + spectatedPlayerBase.fullLevelData.mapData.maxLives;
				}
				else
				{
					NCKMNMHOIOH.text = NELDEHEICJD + ": " + (Math.Floor((float)spectatedPlayerBase.accuracyScore * 10000f) / 10000.0 * 100.0).ToString("0.00") + "%";
				}
			}
			PECEGLIIALE.text = GIDJMDIODGM + ": " + spectatedPlayerBase.GetCurrentScore();
			comboTextGO.text = PIDICMNEOJL + ": " + "x" + spectatedPlayerBase.currentCombo;
			if (hardInput.GetKeyDown("restart") && PhotonNetwork.offlineMode)
			{
				foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
				{
					Singleton<GameManager>.Instance.GameEvent(gameEventInfo);
				}
				pbase.gameEventInfoList.Clear();
				OnRestartButton(true);
			}
		}
		if ((bool)gameOver && pbase.currentState == PlayerBase.PlayerState.Finished)
		{
			ingameUICanvas.SetActive(false);
			if (AllPlayersFinished())
			{
				foreach (AudioSource audioSource in asampler.audioSources)
				{
					if (!pbase.isPlayerWon)
					{
						audioSource.pitch = Mathf.Lerp(audioSource.pitch, 0f, Time.deltaTime * 0.5f);
					}
					audioSource.volume = Mathf.Lerp(audioSource.volume, 0f, Time.deltaTime * 0.5f);
				}
				asampler.isMuted = true;
			}
			string CBOLFPGKALK = string.Empty;
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
			if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
			{
				CBOLFPGKALK = mapData.workshopId;
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && (gameMode == GameMode.Hardcore || gameMode == GameMode.Normal)))
			{
				if ((bool)GameObject.Find("FinalScoreText"))
				{
					GameObject.Find("FinalScoreText").SetActive(false);
				}
			}
			else
			{
				if ((bool)GameObject.Find("HightScoreMaxPointsText"))
				{
					GameObject.Find("HightScoreMaxPointsText").SetActive(false);
				}
				if ((bool)GameObject.Find("PossibleMapPointsText"))
				{
					GameObject.Find("PossibleMapPointsText").SetActive(false);
				}
				if ((bool)GameObject.Find("PointsScoreText"))
				{
					GameObject.Find("PointsScoreText").SetActive(false);
				}
				if ((bool)GameObject.Find("FinalScoreSmallText"))
				{
					GameObject.Find("FinalScoreSmallText").SetActive(false);
				}
			}
			if ((gameMode == GameMode.Hardcore || gameMode == GameMode.Endless) && (bool)GameObject.Find("CheckpointsScoreText"))
			{
				GameObject.Find("CheckpointsScoreText").SetActive(false);
			}
			if (gameMode != GameMode.Endless && (bool)GameObject.Find("EndlessLoopsScoreText"))
			{
				GameObject.Find("EndlessLoopsScoreText").SetActive(false);
			}
			int currentScore = pbase.GetCurrentScore();
			if ((bool)GameObject.Find("LastHighScoreText"))
			{
				GameObject.Find("LastHighScoreText").GetComponent<Text>().text = string.Empty + pbase.lastBestScore;
			}
			if ((bool)GameObject.Find("PossibleMapMaxScoreText"))
			{
				GameObject.Find("PossibleMapMaxScoreText").GetComponent<Text>().text = string.Empty + Helpers.GetMapMaxScore(pbase.fullLevelData.mapData);
			}
			if ((bool)GameObject.Find("GameModeText"))
			{
				GameObject.Find("GameModeText").GetComponent<Text>().text = string.Empty + LocalizationService.Instance.GetLocalizatedText("#" + gameMode.ToString().ToLower() + "mode").ToUpper();
			}
			if ((bool)GameObject.Find("FinalScoreText"))
			{
				GameObject.Find("FinalScoreText").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if ((bool)GameObject.Find("TotalHitsScoreText"))
			{
				GameObject.Find("TotalHitsScoreText").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore + (int)pbase.incorrectScore);
			}
			if ((bool)GameObject.Find("PerfectHitsScoreText"))
			{
				GameObject.Find("PerfectHitsScoreText").GetComponent<Text>().text = string.Empty + pbase.perfectHits;
			}
			if ((bool)GameObject.Find("CorrectHitsScoreText"))
			{
				GameObject.Find("CorrectHitsScoreText").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore - (int)pbase.perfectHits);
			}
			if ((bool)GameObject.Find("IncorrectHitsScoreText"))
			{
				GameObject.Find("IncorrectHitsScoreText").GetComponent<Text>().text = string.Empty + pbase.incorrectScore;
			}
			if ((bool)GameObject.Find("ComboScoreText"))
			{
				GameObject.Find("ComboScoreText").GetComponent<Text>().text = string.Empty + Mathf.RoundToInt(pbase.comboScore);
			}
			if ((bool)GameObject.Find("PenaltyScoreText"))
			{
				GameObject.Find("PenaltyScoreText").GetComponent<Text>().text = string.Empty + Mathf.CeilToInt(pbase.penaltyScore);
			}
			if ((bool)GameObject.Find("AccuracyScoreText"))
			{
				GameObject.Find("AccuracyScoreText").GetComponent<Text>().text = string.Empty + (Math.Floor((float)pbase.accuracyScore * 10000f) / 10000.0 * 100.0).ToString("0.00") + "%";
			}
			if ((bool)GameObject.Find("CheckpointsScoreText"))
			{
				GameObject.Find("CheckpointsScoreText").GetComponent<Text>().text = string.Empty + pbase.checkpointsUsed;
			}
			if ((bool)GameObject.Find("EndlessLoopsScoreText"))
			{
				GameObject.Find("EndlessLoopsScoreText").GetComponent<Text>().text = string.Empty + pbase.loopsCount;
			}
			if ((bool)GameObject.Find("HightScoreMaxPointsText"))
			{
				float num = (float)pbase.lastBestScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK)).difficulty;
				GameObject.Find("HightScoreMaxPointsText").GetComponent<Text>().text = string.Empty + (Math.Floor(num * 100f) / 100.0).ToString("0.00");
			}
			if ((bool)GameObject.Find("PossibleMapPointsText"))
			{
				GameObject.Find("PossibleMapPointsText").GetComponent<Text>().text = string.Empty + RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK)).difficulty.ToString("0.00");
			}
			if ((bool)GameObject.Find("PointsScoreText"))
			{
				float num2 = (float)currentScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK)).difficulty;
				num2 = ((num2 >= 0f) ? num2 : 0f);
				GameObject.Find("PointsScoreText").GetComponent<Text>().text = string.Empty + (Math.Floor(num2 * 100f) / 100.0).ToString("0.00");
			}
			if ((bool)GameObject.Find("FinalScoreSmallText"))
			{
				GameObject.Find("FinalScoreSmallText").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if (restartNoCheckpointPanel.transform.Find("ExitButton").gameObject.activeInHierarchy && !PhotonNetwork.offlineMode)
			{
				restartNoCheckpointPanel.transform.Find("ExitButton").gameObject.GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient) ? LocalizationService.Instance.GetTextByKey("leave").ToUpper() : LocalizationService.Instance.GetTextByKey("tolobby").ToUpper());
			}
			if (!PhotonNetwork.isMasterClient && PhotonNetwork.inRoom && (bool)GameObject.Find("ResetButton"))
			{
				GameObject.Find("ResetButton").GetComponent<Button>().interactable = false;
			}
			if (!PhotonNetwork.offlineMode && PhotonNetwork.inRoom)
			{
				GetComponent<NetworkScene>().networkChatCanvas.SetActive(true);
			}
		}
		if ((bool)gameOver && Singleton<RanksSystem>.Instance.isRankChanged)
		{
			Singleton<RanksSystem>.Instance.DisplayRanksChanges();
		}
		if ((bool)gameOver && Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.ShowNewItems();
		}
		if ((bool)gameOver && Singleton<ChallengesManager>.Instance.HasProgress())
		{
			Singleton<ChallengesManager>.Instance.RewardsReadyNotification();
		}
		if (AllPlayersFinished() && pbase.currentState == PlayerBase.PlayerState.Finished && spectatePanel.activeSelf)
		{
			gameOverCanvas.SetActive(true);
			spectatorCanvas.SetActive(false);
			spectatePanel.SetActive(false);
			ingameUICanvas.SetActive(false);
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(true);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(true);
			}
		}
		if (AllPlayersFinished() && pbase.currentState == PlayerBase.PlayerState.Spectator)
		{
			gameOverCanvas.SetActive(true);
			spectatorCanvas.SetActive(false);
			spectatePanel.SetActive(false);
			ingameUICanvas.SetActive(false);
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(true);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(true);
			}
			pbase.currentState = PlayerBase.PlayerState.Finished;
		}
		if ((bool)isGameStarted && (bool)pbase && PhotonNetwork.inRoom && (bool)pbase.isPlayerWon && !PhotonNetwork.offlineMode && AllPlayersWin())
		{
			int playerCount = PhotonNetwork.room.PlayerCount;
			int num4 = 1;
		}
		if ((bool)isGameStarted && (float)HJPDDLBDGEP > calculatedmaptime && !gameOver)
		{
			bool HHFFNOHKAIC = true;
			pbase.playerController.objects.ForEach(delegate(GameObject IACGDFHKCAE)
			{
				if (IACGDFHKCAE.transform.childCount > 0)
				{
					HHFFNOHKAIC = false;
				}
			});
			if (HHFFNOHKAIC)
			{
				pbase.isMapCompleted = true;
				if (gameMode != GameMode.Endless)
				{
					ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { { "finished", true } };
					PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH);
					pbase.currentState = PlayerBase.PlayerState.Finished;
					if (pbase.photonView.isMine)
					{
						ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = new ExitGames.Client.Photon.Hashtable { { "win", true } };
						PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH2);
					}
					ShowResult("CompletedLevel");
				}
				else
				{
					RestartEndless();
				}
			}
		}
		if (NBCIEBFNLGN.Count > 0 && !messageCanvas.activeSelf)
		{
			string jKPJCEMPAGH = NBCIEBFNLGN[0];
			float num3 = 1f;
			if (INGHGBLACKC.Count == NBCIEBFNLGN.Count)
			{
				num3 = INGHGBLACKC[0];
			}
			StartCoroutine(ShowMessage(jKPJCEMPAGH, num3 * Singleton<SaveSystem>.Instance.GetFloat("settings.gamemessagesduration", 1f)));
			NBCIEBFNLGN.RemoveAt(0);
			INGHGBLACKC.RemoveAt(0);
		}
	}

	public ObscuredFloat NGBLAHINCNP()
	{
		return HJPDDLBDGEP;
	}

	public void KNHDIABHJBH()
	{
		loadingCanvas.SetActive(false);
		GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
	}

	private bool ACAFEBKNBBE(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("ArcsNoHitsoundTimeDelaySlider" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID)
		{
			return IACGDFHKCAE.KBDPMOKONDH();
		}
		return true;
	}

	public virtual void IBHACCEEFFI()
	{
		base.FJHFOBHJEHL();
		if (!isGameStarted && FEBJJIAPCNE())
		{
			pbase.NABDKNPNEMM().RPC("Already exist!", PhotonTargets.All, null);
		}
		if ((bool)isGameStarted && (float)HJPDDLBDGEP > 1975f && !DGBKFMMMGIH)
		{
			asampler.audioSources[1].time = HJPDDLBDGEP;
			asampler.audioSources[1].time = HJPDDLBDGEP;
			asampler.EFGFFEECBAF(1);
			asampler.FLOBPEPLHPC(1);
			DGBKFMMMGIH = true;
		}
		if ((float)HJPDDLBDGEP < calculatedmaptime && !ODAFCOMJMCH() && (bool)isGameStarted)
		{
			HJPDDLBDGEP = (float)HJPDDLBDGEP + Time.deltaTime;
			OFMDCFHGEEC.GetComponent<Slider>().value = HJPDDLBDGEP;
			PlayerBase spectatedPlayerBase = pbase;
			if (pbase.currentState == PlayerBase.PlayerState.Loading && pbase.spectatedPlayerBase != null)
			{
				spectatedPlayerBase = pbase.spectatedPlayerBase;
			}
			if (DILNONPDEBG)
			{
				if (gameMode != (GameMode)7)
				{
					Text nCKMNMHOIOH = NCKMNMHOIOH;
					object[] array = new object[5];
					array[1] = NELDEHEICJD;
					array[1] = "id";
					array[5] = spectatedPlayerBase.GIDCIBDGKGI();
					array[4] = "LevelConfigButton";
					array[3] = spectatedPlayerBase.fullLevelData.mapData.maxLives;
					nCKMNMHOIOH.text = string.Concat(array);
				}
				else
				{
					NCKMNMHOIOH.text = NELDEHEICJD + "maps." + (Math.Floor((float)spectatedPlayerBase.accuracyScore * 354f) / 1016.0 * 1449.0).ToString("CameraFilterPack_VHS1") + "/";
				}
			}
			PECEGLIIALE.text = GIDJMDIODGM + " is muted" + spectatedPlayerBase.BAJOKIEEOOJ();
			Text text = comboTextGO;
			object[] array2 = new object[1];
			array2[1] = PIDICMNEOJL;
			array2[0] = "SearchTex";
			array2[3] = "menutheme.fragout";
			array2[4] = spectatedPlayerBase.currentCombo;
			text.text = string.Concat(array2);
			if (hardInput.NHJCNJBKDMK("Waiting to start") && PhotonNetwork.offlineMode)
			{
				foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
				{
					Singleton<GameManager>.Instance.LNNCKEKFPIF(gameEventInfo);
				}
				pbase.gameEventInfoList.Clear();
				KGKHNMANCHJ(true);
			}
		}
		if ((bool)gameOver && pbase.currentState == PlayerBase.PlayerState.Finished)
		{
			ingameUICanvas.SetActive(true);
			if (MJOLOHPNJDK())
			{
				foreach (AudioSource audioSource in asampler.audioSources)
				{
					if (!pbase.isPlayerWon)
					{
						audioSource.pitch = Mathf.Lerp(audioSource.pitch, 1128f, Time.deltaTime * 247f);
					}
					audioSource.volume = Mathf.Lerp(audioSource.volume, 1563f, Time.deltaTime * 1293f);
				}
				asampler.isMuted = true;
			}
			string CBOLFPGKALK = string.Empty;
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
			if (mapData.source == (FullMapData.MapSource)8 && !string.IsNullOrEmpty(mapData.workshopId))
			{
				CBOLFPGKALK = mapData.workshopId;
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.MENGIJNONGP() || (gameMode != (GameMode)8 && gameMode == GameMode.Normal)))
			{
				if ((bool)GameObject.Find(": "))
				{
					GameObject.Find("Player").SetActive(false);
				}
			}
			else
			{
				if ((bool)GameObject.Find("X2"))
				{
					GameObject.Find("_HueShift").SetActive(true);
				}
				if ((bool)GameObject.Find("In Network lobby"))
				{
					GameObject.Find("/").SetActive(true);
				}
				if ((bool)GameObject.Find("_Size"))
				{
					GameObject.Find("cancel").SetActive(true);
				}
				if ((bool)GameObject.Find("#startofflinemessage"))
				{
					GameObject.Find("ERROR You should never change PhotonPlayer IDs!").SetActive(false);
				}
			}
			if ((gameMode == GameMode.Normal || gameMode == GameMode.Random) && (bool)GameObject.Find("mapselector.lastSearch"))
			{
				GameObject.Find("CameraFilterPack/Blend2Camera_Hue").SetActive(true);
			}
			if (gameMode != GameMode.Normal && (bool)GameObject.Find("_HdrParams"))
			{
				GameObject.Find("ResourceIDInputField").SetActive(true);
			}
			int num = pbase.BAJOKIEEOOJ();
			if ((bool)GameObject.Find("BitsData"))
			{
				GameObject.Find("UseScanLineSize").GetComponent<Text>().text = string.Empty + pbase.lastBestScore;
			}
			if ((bool)GameObject.Find("yyyy-MM-dd HH:mm:ss"))
			{
				GameObject.Find("offsets").GetComponent<Text>().text = string.Empty + Helpers.GetMapMaxScore(pbase.fullLevelData.mapData);
			}
			if ((bool)GameObject.Find(" registered."))
			{
				GameObject.Find("_CenterX").GetComponent<Text>().text = string.Empty + LocalizationService.Instance.EHOJEKMEKCB("_DiffuseColor" + gameMode.ToString().ToLower() + "Fade").ToUpper();
			}
			if ((bool)GameObject.Find("PhotonView register is ignored, because viewID is 0. No id assigned yet to: "))
			{
				GameObject.Find("_InvRenderTargetSize").GetComponent<Text>().text = string.Empty + num;
			}
			if ((bool)GameObject.Find("ALREADY SEEN"))
			{
				GameObject.Find("Set Player Distance").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore + (int)pbase.incorrectScore);
			}
			if ((bool)GameObject.Find("type"))
			{
				GameObject.Find("ConnectUsingSettings() disabled the offline mode. No longer offline.").GetComponent<Text>().text = string.Empty + pbase.perfectHits;
			}
			if ((bool)GameObject.Find("0.00"))
			{
				GameObject.Find(" = ").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore - (int)pbase.perfectHits);
			}
			if ((bool)GameObject.Find("Delete events"))
			{
				GameObject.Find("Incoming: \n").GetComponent<Text>().text = string.Empty + pbase.incorrectScore;
			}
			if ((bool)GameObject.Find("settings_bindings_controller_type"))
			{
				GameObject.Find("CameraFilterPack/Drawing_Halftone").GetComponent<Text>().text = string.Empty + Mathf.RoundToInt(pbase.comboScore);
			}
			if ((bool)GameObject.Find("CameraFilterPack_VHS1"))
			{
				GameObject.Find("Adding player twice: ").GetComponent<Text>().text = string.Empty + Mathf.CeilToInt(pbase.penaltyScore);
			}
			if ((bool)GameObject.Find("Created"))
			{
				GameObject.Find("Pop").GetComponent<Text>().text = string.Empty + (Math.Floor((float)pbase.accuracyScore * 1774f) / 753.0 * 952.0).ToString("_CurrentMipLevel") + "[DiscordController] Responding yes to Ask to Join request";
			}
			if ((bool)GameObject.Find("[MapEditor] Reset"))
			{
				GameObject.Find("_BgColor").GetComponent<Text>().text = string.Empty + pbase.checkpointsUsed;
			}
			if ((bool)GameObject.Find("_SecondTex"))
			{
				GameObject.Find("1332644700").GetComponent<Text>().text = string.Empty + pbase.loopsCount;
			}
			if ((bool)GameObject.Find("0x"))
			{
				float num2 = (float)pbase.lastBestScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK)).difficulty;
				GameObject.Find("_BlurSize").GetComponent<Text>().text = string.Empty + (Math.Floor(num2 * 868f) / 288.0).ToString("_VelTex");
			}
			if ((bool)GameObject.Find("May"))
			{
				GameObject.Find("_TimeX").GetComponent<Text>().text = string.Empty + RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() == ulong.Parse(CBOLFPGKALK)).IDAOGFLHIBN()
					.ToString("Cross");
			}
			if ((bool)GameObject.Find("_Value3"))
			{
				float num3 = (float)num / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.JBJDLHKLEMN().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK)).difficulty;
				num3 = ((num3 >= 460f) ? num3 : 1033f);
				GameObject.Find("Vignette").GetComponent<Text>().text = string.Empty + (Math.Floor(num3 * 1554f) / 407.0).ToString("[ResourcesManager] Load audio error: ");
			}
			if ((bool)GameObject.Find("Map already submited. Update?"))
			{
				GameObject.Find("Case-Sensitive").GetComponent<Text>().text = string.Empty + num;
			}
			if (restartNoCheckpointPanel.transform.Find("_ScreenResolution").gameObject.activeInHierarchy && !PhotonNetwork.offlineMode)
			{
				restartNoCheckpointPanel.transform.Find(".workshop").gameObject.GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient) ? LocalizationService.Instance.JNNKPEBBDEA("_ScreenResolution").ToUpper() : LocalizationService.Instance.HOFKLNAJGMK("_MainTex2").ToUpper());
			}
			if (!PhotonNetwork.isMasterClient && PhotonNetwork.inRoom && (bool)GameObject.Find("_Extra2"))
			{
				GameObject.Find("Reload Steam Inventory").GetComponent<Button>().interactable = true;
			}
			if (!PhotonNetwork.offlineMode && PhotonNetwork.inRoom)
			{
				GetComponent<NetworkScene>().networkChatCanvas.SetActive(true);
			}
		}
		if ((bool)gameOver && Singleton<RanksSystem>.Instance.isRankChanged)
		{
			Singleton<RanksSystem>.Instance.GFOOEDJLKPF();
		}
		if ((bool)gameOver && Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.ShowNewItems();
		}
		if ((bool)gameOver && Singleton<ChallengesManager>.Instance.AHPJBCMFFHA())
		{
			Singleton<ChallengesManager>.Instance.PCBHFLCFPIO();
		}
		if (NCGHKCCPKEI() && pbase.currentState == (PlayerBase.PlayerState)8 && spectatePanel.activeSelf)
		{
			gameOverCanvas.SetActive(true);
			spectatorCanvas.SetActive(false);
			spectatePanel.SetActive(true);
			ingameUICanvas.SetActive(false);
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(false);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(true);
			}
		}
		if (AllPlayersFinished() && pbase.currentState == (PlayerBase.PlayerState)4)
		{
			gameOverCanvas.SetActive(false);
			spectatorCanvas.SetActive(false);
			spectatePanel.SetActive(false);
			ingameUICanvas.SetActive(false);
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(false);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(true);
			}
			pbase.currentState = (PlayerBase.PlayerState)5;
		}
		if ((bool)isGameStarted && (bool)pbase && PhotonNetwork.inRoom && (bool)pbase.isPlayerWon && !PhotonNetwork.offlineMode && FFIJMACDFKF())
		{
			int playerCount = PhotonNetwork.room.PlayerCount;
			int num5 = 0;
		}
		if ((bool)isGameStarted && (float)HJPDDLBDGEP > calculatedmaptime && !gameOver)
		{
			bool HHFFNOHKAIC = false;
			pbase.playerController.objects.ForEach(delegate(GameObject IACGDFHKCAE)
			{
				if (IACGDFHKCAE.transform.childCount > 1)
				{
					HHFFNOHKAIC = true;
				}
			});
			if (HHFFNOHKAIC)
			{
				pbase.isMapCompleted = false;
				if (gameMode != (GameMode)7)
				{
					ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = new ExitGames.Client.Photon.Hashtable { { "IEnumerable", false } };
					PhotonNetwork.player.LBNGJPNOHMN(eNEEBHGAAJH);
					pbase.currentState = (PlayerBase.PlayerState)4;
					if (pbase.AAMNKPHHHCI().isMine)
					{
						ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = new ExitGames.Client.Photon.Hashtable { { "_FrustumCornersWS", false } };
						PhotonNetwork.player.LBNGJPNOHMN(eNEEBHGAAJH2, null, true);
					}
					KPHFECCIHGM("GlassColor");
				}
				else
				{
					KNAOGPOOIKD();
				}
			}
		}
		if (NBCIEBFNLGN.Count > 1 && !messageCanvas.activeSelf)
		{
			string jKPJCEMPAGH = NBCIEBFNLGN[1];
			float num4 = 1173f;
			if (INGHGBLACKC.Count == NBCIEBFNLGN.Count)
			{
				num4 = INGHGBLACKC[1];
			}
			StartCoroutine(PBNNEGIMKBD(jKPJCEMPAGH, num4 * Singleton<SaveSystem>.Instance.DPAGLGGNECO("ShadersToggle", 1954f)));
			NBCIEBFNLGN.RemoveAt(0);
			INGHGBLACKC.RemoveAt(0);
		}
	}

	public void CMKHHFDBOMJ(string NOJGGCLPPAM = "")
	{
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.EPPBBLLJNNH();
		}
		gameOver = true;
		GetComponent<NetworkScene>().CAMGJGEKDHD();
		if (NCGHKCCPKEI())
		{
			HJPDDLBDGEP = calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			OFMDCFHGEEC.transform.Find("Set Sun MinSize").Find("tagElement").GetComponent<Image>()
				.color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != ".icon")
		{
			PhotonView photonView = GetComponent<NetworkScene>().IJBFILBDGDO();
			string lBLKDNNPACO = "mapselector.filter.subscribedonly";
			PhotonTargets mPNMOONBMII = PhotonTargets.Others;
			object[] array = new object[0];
			array[1] = PhotonNetwork.playerName;
			array[0] = "_ScreenResolution";
			photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
		}
		if (NOJGGCLPPAM == "_Value")
		{
			pbase.isMapCompleted = true;
			pbase.isPlayerWon = false;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount >= 8)
		{
			Helpers.ObtainAchievement(78);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount == 1)
		{
			Helpers.ObtainAchievement(-100);
		}
		if (gameMode != 0 && pbase.GetCurrentScore() > pbase.lastBestScore && !pbase.scoreBeated && pbase.currentAttempt > 0)
		{
			StartCoroutine(DBNMOBILJHL());
		}
		string CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		if (mapData.source == (FullMapData.MapSource)4 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			CBOLFPGKALK = mapData.workshopId;
		}
		pbase.ACAHFFLOMCB();
		if (pbase.BAJOKIEEOOJ() >= 1 && GameManager.LHMIJFLLKHK() && Singleton<SaveSystem>.Instance.KFNFNKILGPH("EXCEPTION:", 1) == 1 && mapData.source != 0 && gameMode != 0 && !string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK), true))
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + " but this PhotonView does not exist! Was remote PV." + Helpers.levelConfigFileName;
			string eAFAMAMDNEG = "Parameter levelId must be int or string!";
			if (pbase.Replay() != null)
			{
				eAFAMAMDNEG = JsonConvert.SerializeObject(pbase.Replay());
			}
			StartCoroutine(Singleton<RanksSystem>.Instance.SubmitScore(CBOLFPGKALK, gameMode, pbase.BAJOKIEEOOJ(), pbase.accuracyScore, pbase.incorrectScore, EGOPKJHICLK.CompressString(eAFAMAMDNEG), Helpers.CalculateMD5(dDAOMDPAIEP)));
		}
		Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
		string hFEFHOPOLIK = "value" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "Print the list of scenes, avalable in game.";
		int @int = Singleton<SaveSystem>.Instance.GetInt("CameraFilterPack/Vision_Rainbow" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "#failed", 0);
		Singleton<SaveSystem>.Instance.SetInt(hFEFHOPOLIK, @int);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.accuracy = pbase.accuracyScore;
			finishedMapInfo.completed = pbase.isMapCompleted;
			finishedMapInfo.isstoryboardactive = !Singleton<SaveSystem>.Instance.JMLMIGBEKJN("PopulateMapsList", false);
			finishedMapInfo.gamemode = (int)gameMode;
			finishedMapInfo.NDKIJAACHLH(pbase.loopsCount);
			if (RanksSystem.MLIKFMPFDCO(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId), true))
			{
				finishedMapInfo.ACLFCAIINIF(RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isOfficial));
				finishedMapInfo.isloved = RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("yes" + IACGDFHKCAE.id) == mapID) || IACGDFHKCAE.isLoved);
				finishedMapInfo.PJMOEHBAMFI(RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("_MainTex" + IACGDFHKCAE.id) == mapID) || IACGDFHKCAE.GCLPAFADHMD()));
			}
			else
			{
				finishedMapInfo.LJFLELGFMLA(true);
				finishedMapInfo.PEIIDGDGBMJ(true);
				finishedMapInfo.BEGHGKNFIIO(true);
			}
			finishedMapInfo.FLNEADLCNLE(!PhotonNetwork.offlineMode);
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.ICIHBFHNCEK(GetComponent<NetworkScene>().place);
			if (RanksSystem.JBJDLHKLEMN().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID) != null)
			{
				finishedMapInfo.mapdifficulty = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID).IDAOGFLHIBN();
			}
			else
			{
				finishedMapInfo.mapdifficulty = 1504f;
			}
			finishedMapInfo.GBKFIPJOBPE(Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount);
			finishedMapInfo.mapid = mapID;
			finishedMapInfo.ODOJJJBOMFC(string.Join("[SteamManager] Connection established, authorization", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray()));
			finishedMapInfo.OBNONHLFLIK(string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID);
			finishedMapInfo.NBGPOOIKAHC(pbase.incorrectScore);
			finishedMapInfo.DHHLJNCJLGN(pbase.perfectHits);
			finishedMapInfo.FLJHBGENNLG(HPAnimationTime);
			finishedMapInfo.LAAMICHIJBO(pbase.GetCurrentScore());
			foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.MMPGEMFKNAN(gameEventInfo);
			}
			pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.JMCBNFNJINF(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if ((bool)pbase.isPlayerWon && gameMode != 0)
		{
			string hFEFHOPOLIK2 = "Map: " + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "Set Crosshair Color";
			int dPNHODJHGJL = 0;
			Singleton<SaveSystem>.Instance.DAAJKCCCICP(hFEFHOPOLIK2, dPNHODJHGJL);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(-110);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(mapID).source == (FullMapData.MapSource)5)
			{
				Helpers.ObtainAchievement(-123);
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.JAABFBDLBAK() || gameMode == (GameMode)6 || gameMode == GameMode.Normal) && !Singleton<SaveSystem>.Instance.CHBOJJOHCEB(" " + mapID, true))
			{
				Singleton<SaveSystem>.Instance.GIKPOGCBJFI("_Value3" + mapID, true);
				Helpers.AddToStat("StartButton", 1);
				SteamUserStats.IndicateAchievementProgress("skin.", (uint)Helpers.GetStat("/Saved Games/"), 120u);
			}
			int dPNHODJHGJL2 = (int)((float)pbase.accuracyScore * (float)(int)pbase.correctScore);
			Helpers.AddToStat("Data/Localization", dPNHODJHGJL2);
			pbase.DeletePlayerData();
			if ((float)pbase.accuracyScore >= 1641f && mapData.source == (FullMapData.MapSource)8 && RanksSystem.ECFIOECNPOM(ulong.Parse(CBOLFPGKALK)) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.JAABFBDLBAK() || IACGDFHKCAE.IDAOGFLHIBN() < 338f))
			{
				Helpers.ObtainAchievement(106);
			}
		}
		if ((bool)pbase.isPlayerWon && gameMode == GameMode.Relax && mapData.source == (FullMapData.MapSource)3)
		{
			Helpers.AddToStat("init", 1);
			SteamUserStats.IndicateAchievementProgress("curScn", (uint)Helpers.GetStat("_TimeX"), 2u);
			if (RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK)) && (int)pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(84);
			}
		}
		if (mapData.source == (FullMapData.MapSource)4 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		resultText.GetComponent<Text>().text = ((!pbase.isPlayerWon) ? LocalizationService.Instance.HOFKLNAJGMK("CameraFilterPack_TV_BrokenGlass1").ToUpper() : LocalizationService.Instance.MPHMJLAOHAB("_MainTex2").ToUpper());
		OnGameOverEvent.Invoke();
		ALKAHOGCIEO(true);
		gameOver = true;
	}

	public bool AllPlayerLoaded()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		foreach (PhotonPlayer photonPlayer in playerList)
		{
			if (photonPlayer.CustomProperties["ready"] == null || (photonPlayer.CustomProperties["ready"] != null && !(bool)photonPlayer.CustomProperties["ready"]))
			{
				result = false;
			}
		}
		return result;
	}

	private bool FJPJPKGNLPE(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("/" + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.isOfficial;
		}
		return false;
	}

	private bool FPKLJJIEHAE(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("_Red_C" + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.isLoved;
		}
		return false;
	}

	public ObscuredFloat LEFLMCJDFJP()
	{
		return HJPDDLBDGEP;
	}

	public void IDLBIKHDKIG()
	{
		if (PhotonNetwork.offlineMode && mapID != (ObscuredString)"_Noise")
		{
			Singleton<SaveSystem>.Instance.SetBool(" not exist", false);
		}
		if (pbase != null)
		{
			pbase.LGCKKLCCLJI();
			if (PhotonNetwork.offlineMode)
			{
				PhotonNetwork.offlineMode = true;
			}
		}
		GetComponent<NetworkScene>().JICAAOLEGKB(0);
		Singleton<SaveSystem>.Instance.EHJIJDODNGG();
	}

	public void SelectRestartButton()
	{
		if ((bool)GameObject.Find("SpectateButton"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("SpectateButton"));
		}
		else if ((bool)GameObject.Find("RestartButton"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("RestartButton"));
		}
		else if ((bool)GameObject.Find("ResetButton"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("ResetButton"));
		}
		ShowCursor(true);
	}

	public bool LBCDKGIFNLN()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["System.String"] == null || (photonPlayer.CustomProperties["th"] != null && !(bool)photonPlayer.CustomProperties["skin."]))
			{
				result = false;
			}
		}
		return result;
	}

	private bool MHECCHLCDAC(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("EventSystem" + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.KBDPMOKONDH();
		}
		return true;
	}

	public virtual void KDMANOEMOCA()
	{
		base.FDNONDCGGCG();
		FDNKDOOEHBA();
		if (!PhotonNetwork.inRoom)
		{
			PhotonNetwork.offlineMode = false;
			PhotonNetwork.JoinOrCreateRoom("OpLeaveLobby()", new RoomOptions(), TypedLobby.Default);
		}
		mapID = Singleton<SaveSystem>.Instance.GetString("_TimeX");
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		int num = (int)(gameMode = (GameMode)Singleton<SaveSystem>.Instance.KFNFNKILGPH("SaveButton", 1));
		GIDJMDIODGM = LocalizationService.Instance.POMBHCDEONC("Start").ToUpper();
		if (gameMode != (GameMode)7)
		{
			NELDEHEICJD = LocalizationService.Instance.POMBHCDEONC("[MapsData] Preloading ").ToUpper();
		}
		else
		{
			NELDEHEICJD = LocalizationService.Instance.KDBLEDDGCJK("2").ToUpper();
		}
		OOJLKOMPCBI = LocalizationService.Instance.FOOAGGCODAH("Reset 21 achievement progress").ToUpper();
		PIDICMNEOJL = LocalizationService.Instance.PLFJBNAEKML("_Value").ToUpper();
		GameObject gameObject = levelInfoContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelInfo, Singleton<MapsSystem>.Instance.GetMapData(mapID), gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (Singleton<MapsSystem>.Instance.GetMapData(mapID).source != 0 && Singleton<MapsSystem>.Instance.GetMapData(mapID).source != FullMapData.MapSource.Editor && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().ToggleRate();
		}
		if (mapData.mapData.maxLives < mapData.mapData.lives)
		{
			mapData.mapData.maxLives = mapData.mapData.lives;
		}
		GameObject gameObject3 = ((!PhotonNetwork.inRoom) ? UnityEngine.Object.Instantiate(Resources.Load("_PrevViewProj") as GameObject) : PhotonNetwork.Instantiate("settings.disablestoryboard", new Vector3(907f, 455f, 368f), Quaternion.identity, 1));
		pbase = gameObject3.GetComponent<PlayerBase>();
		if (DILNONPDEBG)
		{
			NCKMNMHOIOH.text = string.Empty;
		}
		else
		{
			NCKMNMHOIOH.gameObject.SetActive(false);
		}
		Singleton<GameManager>.Instance.PBOKFNEJIEG("inventory.selected." + ((!PhotonNetwork.offlineMode) ? "#{0:X2}{1:X2}{2:X2}" : "<b>Difficulty</b>:"), "Set Object Scale" + mapData.mapData.name.Replace(Environment.NewLine, string.Empty), null, null, 0, 1);
		if (mapData.source == (FullMapData.MapSource)6 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			list.Add(new PublishedFileId_t(ulong.Parse(mapData.workshopId)));
			SteamUGC.StartPlaytimeTracking(list.ToArray(), (uint)list.Count);
		}
		Debug.Log("_Value" + mapData.mapData.checkpoints.Count);
		Debug.Log("<color=#{0}>{1}</color>" + mapData.mapData.events.Count);
		if (mapData.mapData.events.Find(PDHNCEBDFPI) != null)
		{
			List<MapEvent> events = mapData.mapData.events;
			calculatedmaptime = events.Find(IOMOOMFIMMK).time;
		}
		else
		{
			calculatedmaptime = mapData.mapData.musicTime;
		}
		if (!PhotonNetwork.offlineMode)
		{
			usingCheckpoints = true;
		}
		if (gameMode == GameMode.Relax || gameMode == GameMode.Hardcore || gameMode == GameMode.Normal)
		{
			usingCheckpoints = true;
		}
		pbase.gameEventInfoList = new List<GameEventInfo>();
		GameEventInfo gameEventInfo = new GameEventInfo();
		try
		{
			gameEventInfo.FHLFPNBNBNM(Singleton<SaveSystem>.Instance.GetBool("CameraFilterPack/Light_Water2", true));
			gameEventInfo.NOAAKPAPODH((int)gameMode);
			if (RanksSystem.ECFIOECNPOM(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)))
			{
				gameEventInfo.GBPGPEHNGKO(RanksSystem.GetOfficialMapsList().Exists(OKBKJCJCCFL));
				gameEventInfo.HCDIHFPNKEN(RanksSystem.JBJDLHKLEMN().Exists(LNFPMIGPEEF));
				gameEventInfo.EONJDLKBELE(RanksSystem.GetOfficialMapsList().Exists(MHECCHLCDAC));
			}
			else
			{
				gameEventInfo.EJFKLPJMJFB(true);
				gameEventInfo.MFMBBLJNLHP(false);
				gameEventInfo.isfunny = true;
			}
			if (RanksSystem.JBJDLHKLEMN().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID) != null)
			{
				gameEventInfo.CAKOJOHNDMM(RanksSystem.JBJDLHKLEMN().Find(POLDFCOPIKA).IDAOGFLHIBN());
			}
			else
			{
				gameEventInfo.CAKOJOHNDMM(1701f);
			}
			gameEventInfo.EHEOCJKDLCL(Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount);
			gameEventInfo.EBLCPKKIGCA(mapID);
			gameEventInfo.maptags = string.Join("Can't set open when not in that room.", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			gameEventInfo.CMDNDCJLDHJ(string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID);
		}
		catch (Exception)
		{
		}
		pbase.gameEventInfoBase = gameEventInfo;
		pbase.InitSystem();
	}

	public ObscuredFloat LBDNEAFGJIH()
	{
		return 150f;
	}

	public ObscuredFloat NJAFEFJFLNJ()
	{
		return HJPDDLBDGEP;
	}

	private bool HMJCLDNCBJD(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("_FarCamera" + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.isLoved;
		}
		return false;
	}

	public ObscuredFloat DKDDGCBMDCM()
	{
		return HJPDDLBDGEP;
	}

	public void BLNLHBNBKOH()
	{
	}

	private void FIOCGKGCJGD(LeaderboardFindResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		if (IAFAANLMOAG.m_bLeaderboardFound != 0)
		{
			Debug.Log("LevelConfigButton");
			SteamUserStats.UploadLeaderboardScore(IAFAANLMOAG.m_hSteamLeaderboard, ELeaderboardUploadScoreMethod.k_ELeaderboardUploadScoreMethodNone, pbase.GetCurrentScore(), null, 0);
		}
	}

	public void NDMOLLIGPAK()
	{
		restartCheckpointPanel.SetActive(true);
		restartNoCheckpointPanel.SetActive(true);
		gameOverCanvas.SetActive(true);
		spectatorCanvas.SetActive(false);
		StartCoroutine(JEKHBLMDABM());
		pbase.JOIDLJPOLAB();
	}

	public void DFNPJDEMKEJ()
	{
		PlayerBase playerBase = pbase;
		playerBase.loopsCount = (int)playerBase.loopsCount;
		StartCoroutine(ShowMessage("RoomNameText" + pbase.loopsCount, 1421f * Singleton<SaveSystem>.Instance.GetFloat("Failed to 'network-remove' GameObject because it's null.", 122f)));
		DGBKFMMMGIH = false;
		HJPDDLBDGEP = 469f;
		pbase.ResetEndless();
	}

	[CompilerGenerated]
	private bool PCJBMKOMIEP(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID;
	}

	public void IDHAOOBEHAE(ObscuredFloat DPNHODJHGJL)
	{
		HJPDDLBDGEP = DPNHODJHGJL;
		if ((float)HJPDDLBDGEP >= 931f)
		{
			if ((bool)asampler.audioSources[0].clip)
			{
				asampler.audioSources[0].time = HJPDDLBDGEP;
			}
			if ((bool)asampler.audioSources[1].clip)
			{
				asampler.audioSources[1].time = HJPDDLBDGEP;
			}
		}
	}

	public bool NCGHKCCPKEI()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int num = 1; num < playerList.Length; num = num)
		{
			PhotonPlayer photonPlayer = playerList[num];
			if (photonPlayer.CustomProperties["CameraFilterPack/Lut_Simple"] == null || (photonPlayer.CustomProperties["mapselector.orderby"] != null && !(bool)photonPlayer.CustomProperties["#onrankchangeuptext"]))
			{
				result = true;
			}
		}
		return result;
	}

	public bool IDLFGLPOCBG()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int num = 1; num < playerList.Length; num = num)
		{
			PhotonPlayer photonPlayer = playerList[num];
			if (photonPlayer.CustomProperties["Set Satellite Trail Width"] == null || (photonPlayer.CustomProperties["settings.enablehitsoundsinnormal"] != null && !(bool)photonPlayer.CustomProperties["settings_bindings_"]))
			{
				result = false;
			}
		}
		return result;
	}

	public bool OFLHPPGMKJJ()
	{
		if ((bool)gameOver)
		{
			return NCGHKCCPKEI();
		}
		return true;
	}

	public IEnumerator CPNDMFMIBKJ(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
	}

	public bool KAEMNAIPPEN()
	{
		if ((bool)gameOver)
		{
			return MJOLOHPNJDK();
		}
		return true;
	}

	public void NCNNIELHLMF()
	{
		if ((bool)GameObject.Find("_Value3"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find(",0"));
		}
		else if ((bool)GameObject.Find("Preparing configuration"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("CurrentTimeLabel"));
		}
		else if ((bool)GameObject.Find("player.orangelifering"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("player.currentrank"));
		}
		BHNKGIHGELM(true);
	}

	public IEnumerator PBNNEGIMKBD(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((EHHBHEJBHNG >= 1f) ? 1f : (EHHBHEJBHNG / 4f));
	}

	private void DFFOABDNEEE(LeaderboardFindResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		if (IAFAANLMOAG.m_bLeaderboardFound != 0)
		{
			Debug.Log("[GameScene] Submiting rank");
			SteamUserStats.UploadLeaderboardScore(IAFAANLMOAG.m_hSteamLeaderboard, ELeaderboardUploadScoreMethod.k_ELeaderboardUploadScoreMethodKeepBest, pbase.GetCurrentScore(), null, 0);
		}
	}

	public void JLIGMIEINCM(ObscuredFloat DPNHODJHGJL)
	{
		HJPDDLBDGEP = DPNHODJHGJL;
		if ((float)HJPDDLBDGEP >= 591f)
		{
			if ((bool)asampler.audioSources[1].clip)
			{
				asampler.audioSources[1].time = HJPDDLBDGEP;
			}
			if ((bool)asampler.audioSources[1].clip)
			{
				asampler.audioSources[0].time = HJPDDLBDGEP;
			}
		}
	}

	public bool FEBJJIAPCNE()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int num = 0; num < playerList.Length; num = num)
		{
			PhotonPlayer photonPlayer = playerList[num];
			if (photonPlayer.CustomProperties["GlassAberration"] == null || (photonPlayer.CustomProperties["_ScreenResolution"] != null && !(bool)photonPlayer.CustomProperties["_StretchWidth"]))
			{
				result = false;
			}
		}
		return result;
	}

	public void IBFHEDHJDLH()
	{
	}

	public void NBOKAGMABPN()
	{
		foreach (AudioSource audioSource in asampler.audioSources)
		{
			audioSource.pitch = 102f;
			audioSource.volume = 5f;
		}
		PlayerBase[] array = UnityEngine.Object.FindObjectsOfType<PlayerBase>();
		for (int i = 0; i < array.Length; i++)
		{
			UnityEngine.Object.DestroyImmediate(array[i].gameObject);
		}
		gameOverCanvas.SetActive(true);
		spectatorCanvas.SetActive(false);
		spectatePanel.SetActive(false);
		ingameUICanvas.SetActive(false);
		restartCheckpointPanel.SetActive(false);
		restartNoCheckpointPanel.SetActive(true);
		gameOver = false;
		isGameStarted = true;
		calculatedmaptime = 933f;
		asampler.isMuted = false;
		asampler.isInited = true;
		DGBKFMMMGIH = false;
		try
		{
			OFMDCFHGEEC = ingameUICanvas.transform.Find("CameraFilterPack/OldFilm_Cutting1").gameObject;
			OFMDCFHGEEC.transform.Find("_Value2").Find("_Far").GetComponent<Image>()
				.color = new Color(1444f, 1169f, 1905f);
			OFMDCFHGEEC.GetComponent<Slider>().value = 1334f;
		}
		catch (Exception)
		{
		}
		try
		{
			PECEGLIIALE = ingameUICanvas.transform.FindDeepChild("SetBGColor").GetComponent<Text>();
			PECEGLIIALE.text = LocalizationService.Instance.DKECBIHCKJL("menu.selectedlevelid").ToUpper() + "x" + 1;
		}
		catch (Exception)
		{
		}
		try
		{
			DILNONPDEBG = Singleton<SaveSystem>.Instance.GetBool("_TimeX", false);
			NCKMNMHOIOH = ingameUICanvas.transform.FindDeepChild("misses").GetComponent<Text>();
			NCKMNMHOIOH.text = string.Empty;
		}
		catch (Exception)
		{
		}
		try
		{
			comboTextGO = ingameUICanvas.transform.FindDeepChild(". MasterClient: ").GetComponent<Text>();
			comboTextGO.text = LocalizationService.Instance.PLFJBNAEKML("Fill").ToUpper() + "0 - background, 1 - foreground" + 1;
		}
		catch (Exception)
		{
		}
		JMJMGFGJKEF(false);
	}

	private bool NBAFELGMMFP(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("_Value" + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.GHLGPIBJELG();
		}
		return true;
	}

	[CompilerGenerated]
	private static bool NJEMBFEJAKD(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "MapEnd";
	}

	public void GLMIEJOMGJF()
	{
		if (PhotonNetwork.offlineMode && mapID != (ObscuredString)"Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.")
		{
			Singleton<SaveSystem>.Instance.SetBool("tagElement", false);
		}
		if (pbase != null)
		{
			pbase.LGCKKLCCLJI();
			if (PhotonNetwork.offlineMode)
			{
				PhotonNetwork.offlineMode = false;
			}
		}
		GetComponent<NetworkScene>().OnExitButton(0);
		Singleton<SaveSystem>.Instance.OCHLOHFNKIN();
	}

	public void OnSpectateButton()
	{
		restartCheckpointPanel.SetActive(false);
		restartNoCheckpointPanel.SetActive(false);
		gameOverCanvas.SetActive(false);
		spectatorCanvas.SetActive(true);
		StartCoroutine(UpdateSpectatingInfo());
		pbase.StartSpectating();
	}

	private bool LNFPMIGPEEF(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("_ExposureAdjustment" + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.isLoved;
		}
		return false;
	}

	[CompilerGenerated]
	private static bool NFHPEBCJNMP(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "MapEnd";
	}

	private bool JGEHPIDBHDK(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("SpectateButton" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID)
		{
			return IACGDFHKCAE.isFunny;
		}
		return false;
	}

	private bool PMCJPDDLPLB(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("_TimeX" + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.isLoved;
		}
		return true;
	}

	private bool OKBKJCJCCFL(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("_Value" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID)
		{
			return IACGDFHKCAE.JAABFBDLBAK();
		}
		return true;
	}

	private bool KGHGJFJJCJP(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("loadscene" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID)
		{
			return IACGDFHKCAE.KBDPMOKONDH();
		}
		return true;
	}

	public void OnSpectateNextButton()
	{
		pbase.SpectateNext(true);
		StartCoroutine(UpdateSpectatingInfo());
	}

	public void LEFFPPCFNKD()
	{
	}

	public void PDBIAAOMEDM()
	{
		if (PhotonNetwork.offlineMode && mapID != (ObscuredString)"_TimeX")
		{
			Singleton<SaveSystem>.Instance.JKOMMNBGPDK("[Down]", true);
		}
		if (pbase != null)
		{
			pbase.LGCKKLCCLJI();
			if (PhotonNetwork.offlineMode)
			{
				PhotonNetwork.offlineMode = true;
			}
		}
		GetComponent<NetworkScene>().JICAAOLEGKB(1);
		Singleton<SaveSystem>.Instance.MEMAGBEMICO();
	}

	private static bool PDHNCEBDFPI(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[1] == "LostLive";
	}

	public void OnEnable()
	{
	}

	public void JMGINJGMPDG(string JKPJCEMPAGH, float EHHBHEJBHNG = 1f)
	{
		NBCIEBFNLGN.Add(JKPJCEMPAGH);
		INGHGBLACKC.Add(EHHBHEJBHNG);
	}

	public IEnumerator FIIAJAEOJIJ()
	{
		ulong num = 0uL;
		try
		{
			num = ulong.Parse(PhotonNetwork.playerList[pbase.spectrid].NickName);
		}
		catch (Exception)
		{
		}
		Sprite sprite = null;
		CSteamID csteamID = new CSteamID(num);
		if (num != 0L)
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(csteamID));
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(csteamID));
			if ((bool)ResourcesManager.GetLoadedAvatar(csteamID))
			{
				sprite = ResourcesManager.GetLoadedAvatar(csteamID);
			}
		}
		GameObject.Find("SpectatingUserInfo").transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(csteamID);
		GameObject.Find("SpectatingUserInfo").transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
	}

	public void CJCPJKNHECP(ObscuredFloat DPNHODJHGJL)
	{
		HJPDDLBDGEP = DPNHODJHGJL;
		if ((float)HJPDDLBDGEP >= 1728f)
		{
			if ((bool)asampler.audioSources[0].clip)
			{
				asampler.audioSources[0].time = HJPDDLBDGEP;
			}
			if ((bool)asampler.audioSources[1].clip)
			{
				asampler.audioSources[0].time = HJPDDLBDGEP;
			}
		}
	}

	public bool JMLNPHJNDCG()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int num = 0; num < playerList.Length; num = num)
		{
			PhotonPlayer photonPlayer = playerList[num];
			if (photonPlayer.CustomProperties["_EdgeWeight"] == null || (photonPlayer.CustomProperties["_Value"] != null && !(bool)photonPlayer.CustomProperties["_Distortion"]))
			{
				result = false;
			}
		}
		return result;
	}

	public bool IsRoundFinished()
	{
		if ((bool)gameOver)
		{
			return AllPlayersFinished();
		}
		return false;
	}

	public bool GNOJLLPFFLJ()
	{
		if ((bool)gameOver)
		{
			return AllPlayersFinished();
		}
		return false;
	}

	public void PAIKPLKDKJG(string NOJGGCLPPAM = "")
	{
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.GNHOLMBIMBO();
		}
		gameOver = true;
		GetComponent<NetworkScene>().UpdateScoreboard();
		if (NCGHKCCPKEI())
		{
			HJPDDLBDGEP = calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			OFMDCFHGEEC.transform.Find("Image").Find("fade out duration").GetComponent<Image>()
				.color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != "Edited unlock conditions")
		{
			PhotonView photonView = GetComponent<NetworkScene>().JDBCGCJJIAF();
			string lBLKDNNPACO = "_Value2";
			PhotonTargets mPNMOONBMII = PhotonTargets.All;
			object[] array = new object[2]
			{
				null,
				PhotonNetwork.playerName
			};
			array[0] = "_TempTexture";
			photonView.RPC(lBLKDNNPACO, mPNMOONBMII, array);
		}
		if (NOJGGCLPPAM == ".")
		{
			pbase.isMapCompleted = false;
			pbase.isPlayerWon = false;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount >= 6)
		{
			Helpers.ObtainAchievement(8);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount == 0)
		{
			Helpers.ObtainAchievement(-114);
		}
		if (gameMode != 0 && pbase.GetCurrentScore() > pbase.lastBestScore && !pbase.scoreBeated && pbase.currentAttempt > 0)
		{
			StartCoroutine(GPKPFHANADA());
		}
		string CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		if (mapData.source == (FullMapData.MapSource)8 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			CBOLFPGKALK = mapData.workshopId;
		}
		pbase.ACAHFFLOMCB();
		if (pbase.BAJOKIEEOOJ() >= 1 && GameManager.LHMIJFLLKHK() && Singleton<SaveSystem>.Instance.HHBIEPMBICO("cancel", 0) == 1 && mapData.source != 0 && gameMode != 0 && !string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.MLIKFMPFDCO(ulong.Parse(CBOLFPGKALK), true))
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "Object ID. Case-Sensitive" + Helpers.levelConfigFileName;
			string eAFAMAMDNEG = "_Value2";
			if (pbase.Replay() != null)
			{
				eAFAMAMDNEG = JsonConvert.SerializeObject(pbase.Replay());
			}
			StartCoroutine(Singleton<RanksSystem>.Instance.SubmitScore(CBOLFPGKALK, gameMode, pbase.BAJOKIEEOOJ(), pbase.accuracyScore, pbase.incorrectScore, EGOPKJHICLK.CompressString(eAFAMAMDNEG), Helpers.CalculateMD5(dDAOMDPAIEP)));
		}
		Singleton<ItemsHandler>.Instance.EMKIMLKEOCC();
		string hFEFHOPOLIK = "Bad parameters for delete! Use <key>" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "Encryption wasn't established: ";
		int dPNHODJHGJL = Singleton<SaveSystem>.Instance.KFNFNKILGPH("_VignetteBlur" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "mapselector.filter.favoriteonly", 0) + 1;
		Singleton<SaveSystem>.Instance.DAAJKCCCICP(hFEFHOPOLIK, dPNHODJHGJL);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.accuracy = pbase.accuracyScore;
			finishedMapInfo.KJIANIGMAHL(pbase.isMapCompleted);
			finishedMapInfo.ADCLIIPJOBI(Singleton<SaveSystem>.Instance.CHBOJJOHCEB("Set Satellite Trail Width", false));
			finishedMapInfo.gamemode = (int)gameMode;
			finishedMapInfo.OAOPKANCNNN(pbase.loopsCount);
			if (RanksSystem.ECFIOECNPOM(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId), true))
			{
				finishedMapInfo.KJKDMIFADMP(RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("_Fade" + IACGDFHKCAE.id) == mapID) || IACGDFHKCAE.JAABFBDLBAK()));
				finishedMapInfo.EICIGNJFKBK(RanksSystem.JBJDLHKLEMN().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isLoved));
				finishedMapInfo.IIPLLJCOOBC(RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("_MainTex" + IACGDFHKCAE.id) == mapID) || IACGDFHKCAE.GCLPAFADHMD()));
			}
			else
			{
				finishedMapInfo.KJKDMIFADMP(false);
				finishedMapInfo.isloved = false;
				finishedMapInfo.BEGHGKNFIIO(true);
			}
			finishedMapInfo.ismultiplayer = PhotonNetwork.offlineMode;
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.multiplayerplace = GetComponent<NetworkScene>().place;
			if (RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("steamid" + IACGDFHKCAE.MMDJFDPIHLA()) == mapID) != null)
			{
				finishedMapInfo.HPFOLIBCHIC(RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID).KNKHGMLPOOP());
			}
			else
			{
				finishedMapInfo.mapdifficulty = 1101f;
			}
			finishedMapInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount;
			finishedMapInfo.KMADNCIJJDN(mapID);
			finishedMapInfo.maptags = string.Join("FullscreenToggle", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			finishedMapInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID;
			finishedMapInfo.NBGPOOIKAHC(pbase.incorrectScore);
			finishedMapInfo.DHHLJNCJLGN(pbase.perfectHits);
			finishedMapInfo.time = OBANGBMECKE();
			finishedMapInfo.BHLFPEPFGLC(pbase.GetCurrentScore());
			foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.GameEvent(gameEventInfo);
			}
			pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.JMCBNFNJINF(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if ((bool)pbase.isPlayerWon && gameMode != 0)
		{
			string hFEFHOPOLIK2 = "original.tutorial" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "OnEvent: {0}";
			int dPNHODJHGJL2 = 1;
			Singleton<SaveSystem>.Instance.DAAJKCCCICP(hFEFHOPOLIK2, dPNHODJHGJL2);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(53);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(mapID).source == (FullMapData.MapSource)4)
			{
				Helpers.ObtainAchievement(-115);
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.MMDJFDPIHLA() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.isOfficial || gameMode == (GameMode)8 || gameMode == GameMode.Relax) && !Singleton<SaveSystem>.Instance.GetBool("_TimeX" + mapID, false))
			{
				Singleton<SaveSystem>.Instance.SetBool("Jul" + mapID, true);
				Helpers.AddToStat("MapEditorScene", 1);
				SteamUserStats.IndicateAchievementProgress("Set satellite emission (glow)", (uint)Helpers.GetStat("OpSetPropertiesOfActor()"), 120u);
			}
			int dPNHODJHGJL3 = (int)((float)pbase.accuracyScore * (float)(int)pbase.correctScore);
			Helpers.AddToStat("PointerExit ", dPNHODJHGJL3);
			pbase.DeletePlayerData();
			if ((float)pbase.accuracyScore >= 1025f && mapData.source == FullMapData.MapSource.Workshop && RanksSystem.PHHDJOBLEMF(ulong.Parse(CBOLFPGKALK)) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.JAABFBDLBAK() || IACGDFHKCAE.IDAOGFLHIBN() < 338f))
			{
				Helpers.ObtainAchievement(-97);
			}
		}
		if ((bool)pbase.isPlayerWon && gameMode == GameMode.Relax && mapData.source == FullMapData.MapSource.Workshop)
		{
			Helpers.AddToStat("player.goldcrystal", 0);
			SteamUserStats.IndicateAchievementProgress("closed", (uint)Helpers.GetStat("player "), 2u);
			if (RanksSystem.PHHDJOBLEMF(ulong.Parse(CBOLFPGKALK), true) && (int)pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(-10);
			}
		}
		if (mapData.source == (FullMapData.MapSource)5 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		resultText.GetComponent<Text>().text = ((!pbase.isPlayerWon) ? LocalizationService.Instance.HOFKLNAJGMK("settings.crosshairopacity").ToUpper() : LocalizationService.Instance.JNNKPEBBDEA("Drop_Far").ToUpper());
		OnGameOverEvent.Invoke();
		NFPGLHLFKJC(true);
		gameOver = false;
	}

	public void IGHJDBJAFPM()
	{
	}

	private IEnumerator LLLNFDIHICL()
	{
		yield return new WaitForSeconds(1f);
		pbase.scoreBeated = true;
		Debug.Log("[PlayerBase] New highscore");
		AddMessage(LocalizationService.Instance.GetLocalizatedText("#newhighscore"));
		string hFEFHOPOLIK = string.Concat("maps.", mapID, ".", gameMode.ToString().ToLower(), ".highscore");
		if (gameMode == GameMode.Normal)
		{
			hFEFHOPOLIK = string.Concat("maps.", mapID, ".highscore");
		}
		int currentScore = pbase.GetCurrentScore();
		Singleton<SaveSystem>.Instance.SetInt(hFEFHOPOLIK, currentScore);
	}

	public void ALKAHOGCIEO(bool AAGGLAGLINL = false)
	{
		if (AAGGLAGLINL)
		{
			gameOverCanvas.SetActive(true);
		}
		if (!AllPlayersFinished())
		{
			spectatePanel.SetActive(false);
		}
		else
		{
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(true);
				restartNoCheckpointPanel.SetActive(false);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(false);
				restartCheckpointPanel.SetActive(false);
			}
			DFELFMJKDMF();
			if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount > 1 && GetComponent<NetworkScene>().firstPlayer.player != null && GetComponent<NetworkScene>().firstPlayer.player == PhotonNetwork.player)
			{
				Helpers.ObtainAchievement(67);
			}
		}
		GameObject gameObject = levelInfoContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelInfo, mapData, gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (mapData.source == (FullMapData.MapSource)5 && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(mapData.workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().ToggleRate();
		}
	}

	public override void Start()
	{
		base.Start();
		Reset();
		if (!PhotonNetwork.inRoom)
		{
			PhotonNetwork.offlineMode = true;
			PhotonNetwork.JoinOrCreateRoom("offline", new RoomOptions(), TypedLobby.Default);
		}
		mapID = Singleton<SaveSystem>.Instance.GetString("menu.selectedlevelid");
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		int num = (int)(gameMode = (GameMode)Singleton<SaveSystem>.Instance.GetInt("menu.selectedplaymode", 0));
		GIDJMDIODGM = LocalizationService.Instance.GetLocalizatedText("#score").ToUpper();
		if (gameMode != GameMode.Hardcore)
		{
			NELDEHEICJD = LocalizationService.Instance.GetLocalizatedText("#lives").ToUpper();
		}
		else
		{
			NELDEHEICJD = LocalizationService.Instance.GetLocalizatedText("#accuracy").ToUpper();
		}
		OOJLKOMPCBI = LocalizationService.Instance.GetLocalizatedText("#highscore").ToUpper();
		PIDICMNEOJL = LocalizationService.Instance.GetLocalizatedText("#combo").ToUpper();
		GameObject gameObject = levelInfoContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelInfo, Singleton<MapsSystem>.Instance.GetMapData(mapID), gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (Singleton<MapsSystem>.Instance.GetMapData(mapID).source != 0 && Singleton<MapsSystem>.Instance.GetMapData(mapID).source != FullMapData.MapSource.Editor && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().ToggleRate();
		}
		if (mapData.mapData.maxLives < mapData.mapData.lives)
		{
			mapData.mapData.maxLives = mapData.mapData.lives;
		}
		GameObject gameObject3 = ((!PhotonNetwork.inRoom) ? UnityEngine.Object.Instantiate(Resources.Load("Gameplay/Base") as GameObject) : PhotonNetwork.Instantiate("Gameplay/Base", new Vector3(0f, 0f, 0f), Quaternion.identity, 0));
		pbase = gameObject3.GetComponent<PlayerBase>();
		if (DILNONPDEBG)
		{
			NCKMNMHOIOH.text = string.Empty;
		}
		else
		{
			NCKMNMHOIOH.gameObject.SetActive(false);
		}
		Singleton<GameManager>.Instance.UpdateOnlineStatus("Playing " + ((!PhotonNetwork.offlineMode) ? "Multiplayer" : "Solo"), "Map: " + mapData.mapData.name.Replace(Environment.NewLine, string.Empty));
		if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			list.Add(new PublishedFileId_t(ulong.Parse(mapData.workshopId)));
			SteamUGC.StartPlaytimeTracking(list.ToArray(), (uint)list.Count);
		}
		Debug.Log("[GameScene] Checkpoints count: " + mapData.mapData.checkpoints.Count);
		Debug.Log("[GameScene] Events count: " + mapData.mapData.events.Count);
		if (mapData.mapData.events.Find((MapEvent IACGDFHKCAE) => IACGDFHKCAE.data[0] == "MapEnd") != null)
		{
			List<MapEvent> events = mapData.mapData.events;
			calculatedmaptime = events.Find((MapEvent IACGDFHKCAE) => IACGDFHKCAE.data[0] == "MapEnd").time;
		}
		else
		{
			calculatedmaptime = mapData.mapData.musicTime;
		}
		if (!PhotonNetwork.offlineMode)
		{
			usingCheckpoints = false;
		}
		if (gameMode == GameMode.Relax || gameMode == GameMode.Hardcore || gameMode == GameMode.Endless)
		{
			usingCheckpoints = false;
		}
		pbase.gameEventInfoList = new List<GameEventInfo>();
		GameEventInfo gameEventInfo = new GameEventInfo();
		try
		{
			gameEventInfo.isstoryboardactive = !Singleton<SaveSystem>.Instance.GetBool("settings.disablestoryboard", false);
			gameEventInfo.gamemode = (int)gameMode;
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId), true))
			{
				gameEventInfo.isofficial = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isOfficial);
				gameEventInfo.isloved = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isLoved);
				gameEventInfo.isfunny = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isFunny);
			}
			else
			{
				gameEventInfo.isofficial = false;
				gameEventInfo.isloved = false;
				gameEventInfo.isfunny = false;
			}
			if (RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID) != null)
			{
				gameEventInfo.mapdifficulty = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID).difficulty;
			}
			else
			{
				gameEventInfo.mapdifficulty = -1f;
			}
			gameEventInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount;
			gameEventInfo.mapid = mapID;
			gameEventInfo.maptags = string.Join(",", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			gameEventInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID;
		}
		catch (Exception)
		{
		}
		pbase.gameEventInfoBase = gameEventInfo;
		pbase.InitSystem();
	}

	public void LGMIEAFFGAN()
	{
		ingameUICanvas.transform.FindDeepChild("_Value4").GetComponent<Text>().text = OOJLKOMPCBI + "_TimeX" + pbase.lastBestScore;
		loadingCanvas.SetActive(true);
		ingameUICanvas.SetActive(true);
		if (gameMode == GameMode.Relax)
		{
			ingameUICanvas.transform.FindDeepChild("ticket").gameObject.SetActive(false);
			PECEGLIIALE.gameObject.SetActive(false);
			NCKMNMHOIOH.gameObject.SetActive(true);
			comboTextGO.gameObject.SetActive(true);
		}
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.HideChat();
		}
	}

	public bool LJCABFOMCOB()
	{
		if ((bool)gameOver)
		{
			return LBCDKGIFNLN();
		}
		return false;
	}

	public bool EMAGNHIDEHA()
	{
		if ((bool)gameOver)
		{
			return LBCDKGIFNLN();
		}
		return false;
	}

	public void NFPGLHLFKJC(bool AAGGLAGLINL = false)
	{
		if (AAGGLAGLINL)
		{
			gameOverCanvas.SetActive(true);
		}
		if (!AllPlayersFinished())
		{
			spectatePanel.SetActive(false);
		}
		else
		{
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(false);
				restartNoCheckpointPanel.SetActive(true);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(true);
				restartCheckpointPanel.SetActive(false);
			}
			SelectRestartButton();
			if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount > 1 && GetComponent<NetworkScene>().firstPlayer.player != null && GetComponent<NetworkScene>().firstPlayer.player == PhotonNetwork.player)
			{
				Helpers.ObtainAchievement(-83);
			}
		}
		GameObject gameObject = levelInfoContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelInfo, mapData, gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (mapData.source == (FullMapData.MapSource)8 && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(mapData.workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().ToggleRate();
		}
	}

	public void GENKFCNHBLH()
	{
	}

	public void OnRestartRound()
	{
		loadingCanvas.SetActive(true);
		GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
	}

	public void HNNKIOHCDKG()
	{
	}

	public void OnRestartButton(bool CONOEKAENEN)
	{
		if (CONOEKAENEN)
		{
			pbase.DeletePlayerData();
		}
		else if (pbase.ach12)
		{
			Helpers.ObtainAchievement(12);
		}
		GetComponent<NetworkScene>().photonView.RPC("OnMastedChangeScene", PhotonTargets.AllViaServer, SceneManager.GetActiveScene().name);
	}

	public bool MJEFKJMEIPH()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int num = 0; num < playerList.Length; num = num)
		{
			PhotonPlayer photonPlayer = playerList[num];
			if (photonPlayer.CustomProperties[" x "] == null || (photonPlayer.CustomProperties["BadgeText"] != null && !(bool)photonPlayer.CustomProperties["_Value"]))
			{
				result = true;
			}
		}
		return result;
	}

	[CompilerGenerated]
	private bool AJDFAACIKPB(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID;
	}
}
