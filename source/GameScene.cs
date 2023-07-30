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

	public ObscuredBool gameOver;

	public ObscuredBool isGameStarted;

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

	public bool usingCheckpoints;

	public GameMode gameMode;

	public UnityEvent OnLoaded;

	public GameObject restartCheckpointPanel;

	public GameObject restartNoCheckpointPanel;

	public GameObject spectatePanel;

	public GameObject levelInfo;

	public GameObject levelInfoContent;

	public float calculatedmaptime;

	private ObscuredBool DGBKFMMMGIH;

	private List<string> NBCIEBFNLGN;

	private List<float> INGHGBLACKC;

	private string GIDJMDIODGM;

	private string NELDEHEICJD;

	private string OOJLKOMPCBI;

	private string PIDICMNEOJL;

	private GameObject OFMDCFHGEEC;

	private Text PECEGLIIALE;

	private Text NCKMNMHOIOH;

	[HideInInspector]
	public Text comboTextGO;

	private bool DILNONPDEBG;

	private ObscuredFloat HJPDDLBDGEP;

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

	[CompilerGenerated]
	private bool IsLoved(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.isLoved;
		}
		return false;
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

	[CompilerGenerated]
	private bool IsFunny(RanksSystem.Map IACGDFHKCAE)
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

	[CompilerGenerated]
	private bool IsOfficial(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.isOfficial;
		}
		return false;
	}

	private IEnumerator NewHighscore()
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
			StartCoroutine(NewHighscore());
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

	public void RestartEndless()
	{
		++pbase.loopsCount;
		StartCoroutine(ShowMessage("#loopnumber " + pbase.loopsCount, 1f * Singleton<SaveSystem>.Instance.GetFloat("settings.gamemessagesduration", 1f)));
		DGBKFMMMGIH = false;
		HJPDDLBDGEP = -1f;
		pbase.ResetEndless();
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

	private bool MHECCHLCDAC(RanksSystem.Map IACGDFHKCAE)
	{
		if ((ObscuredString)("EventSystem" + IACGDFHKCAE.id) == mapID)
		{
			return IACGDFHKCAE.KBDPMOKONDH();
		}
		return true;
	}

	[CompilerGenerated]
	private bool MakeMapIDAgain(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID;
	}

	public GameScene()
	{
		gameOver = false;
		isGameStarted = false;
		usingCheckpoints = true;
		gameMode = GameMode.Normal;
		DGBKFMMMGIH = false;
		NBCIEBFNLGN = new List<string>();
		INGHGBLACKC = new List<float>();
		GIDJMDIODGM = string.Empty;
		NELDEHEICJD = string.Empty;
		OOJLKOMPCBI = string.Empty;
		PIDICMNEOJL = string.Empty;
		HJPDDLBDGEP = 0f;
	}

	[CompilerGenerated]
	private static bool FindMapEnd(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "MapEnd";
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

	[CompilerGenerated]
	private static bool FindMapEndAgain(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "MapEnd";
	}

	public void OnSpectateNextButton()
	{
		pbase.SpectateNext(true);
		StartCoroutine(UpdateSpectatingInfo());
	}

	public void OnEnable()
	{
	}

	public bool IsRoundFinished()
	{
		if ((bool)gameOver)
		{
			return AllPlayersFinished();
		}
		return false;
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

	public void OnRestartRound()
	{
		loadingCanvas.SetActive(true);
		GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
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

	[CompilerGenerated]
	private bool MakeMapID(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID;
	}
}
