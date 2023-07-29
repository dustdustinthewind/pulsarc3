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

		internal bool PCJBHKELGNM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool GGOLDDMONEO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool LHHFJBIAHCN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.BJBPMLKECIA() && ADPIKBBAKHP.gameMode != GameMode.Endless && ADPIKBBAKHP.gameMode == GameMode.Relax;
		}

		internal bool ENINHNANGPG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool BLEKGEPJBFN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.KFMNMCJFPPI() || (ADPIKBBAKHP.gameMode != GameMode.Normal && ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool AOCLLLHOEPF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool GKNGIBMOHBG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool FBGEJBKEPFI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool EGJAIPCIJEO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool ILMDLDPMCBD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.isOfficial || (ADPIKBBAKHP.gameMode != (GameMode)7 && ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool BNABGIKKBLP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool FKOIPBAKJDE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && (ADPIKBBAKHP.gameMode == GameMode.Relax || ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool BEFHJKGDBHJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool PAHEEBJDAEA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool ODODGALBCPH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool HKCAPINMNFF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool CNEFGIKLOGL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool PJHNGEPABHB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool LHDKMBKLNPL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool BHMNMHFDPLN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool CNFFIABGOKN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool FCAGEDLBBHD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.KFMNMCJFPPI() || ADPIKBBAKHP.gameMode == (GameMode)6 || ADPIKBBAKHP.gameMode == GameMode.Relax;
		}

		internal bool FLCOLKKLFPH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool AFIPGCELCFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool ONDNJLFLNMF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool PKJCCIGEACE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool CKLEFMLCEBN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool JLAJGEPNAJO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool FMCCGLHBGOL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool EJEBFELHMGM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool BEFJFFLBLCE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool EKNKLPPOIPN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool LLMELNAGMNA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool NEIDGMKKCBI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool DGDCNDCGPCP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool PODLCOEIIGA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool LJDLIIIPIIJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.CILAHEMDKNO() || ADPIKBBAKHP.gameMode == (GameMode)6 || ADPIKBBAKHP.gameMode == GameMode.Relax;
		}

		internal bool MPOCBBDLGMP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool NFHJNMELIEI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool BAOFCDGMECG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool HHGPEDICCCI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool OJFHDDECJKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool CGMENGEHBKH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool OPLBAOKOOJN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool PDCEJFJILFL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool BJGDNLAOMHE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool PHKLCGKAKON(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool HKLBHBIENLO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool FMIHBNPKEEO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.GPAPLIKKEOH() && (ADPIKBBAKHP.gameMode == GameMode.Normal || ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool FAKMANMIGEP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool FDIHIDKBBAD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool MACILKHEBEF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool DGCJLJMCNGH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool HIHNMOEFONO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool JJDBNMIFCHM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool KFGCBAHGDNK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool KOKDJJJIGCC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool PIJAOCFAPKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.CILAHEMDKNO() || ADPIKBBAKHP.gameMode == GameMode.Hidden || ADPIKBBAKHP.gameMode == GameMode.Relax;
		}

		internal bool ALCLIPCDCFF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool BJMAIJDIKCN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.GPAPLIKKEOH() || (ADPIKBBAKHP.gameMode != GameMode.Hidden && ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool GLHKGBNIHFH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.KFMNMCJFPPI() || ADPIKBBAKHP.gameMode == GameMode.Endless || ADPIKBBAKHP.gameMode == GameMode.Normal;
		}

		internal bool BJCNLIJFEKF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool PNJOGNDMFBD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.BJBPMLKECIA() || (ADPIKBBAKHP.gameMode != (GameMode)6 && ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool OFLDIMDDLHM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.BMKGKMJPAMF() && ADPIKBBAKHP.gameMode != GameMode.Endless && ADPIKBBAKHP.gameMode == GameMode.Relax;
		}

		internal bool EJBBFECHIOD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool CHPMMDDOFKM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.CILAHEMDKNO() && ADPIKBBAKHP.gameMode != (GameMode)7 && ADPIKBBAKHP.gameMode == GameMode.Relax;
		}

		internal bool IJEMMODBHFI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.CDPELGPJPND() && (ADPIKBBAKHP.gameMode == GameMode.Endless || ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool MNCMPEJLMJH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool DFEBIECLKEK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool BNAGFAENIDL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool FHFECFLBHMA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.CDPELGPJPND() && (ADPIKBBAKHP.gameMode == GameMode.Endless || ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool ANJAEKGJILL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool MEMPOPNAEDN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && ADPIKBBAKHP.gameMode != (GameMode)8 && ADPIKBBAKHP.gameMode == GameMode.Relax;
		}

		internal bool BLPJEDJCHKN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.BJBPMLKECIA() && ADPIKBBAKHP.gameMode != GameMode.Hardcore && ADPIKBBAKHP.gameMode == GameMode.Relax;
		}

		internal bool BHIAMFCFHEA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool CJPKAHOENCE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool BFEABMIFIEE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.BMKGKMJPAMF() && (ADPIKBBAKHP.gameMode == GameMode.Random || ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool HHHLDJJNBCG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && (ADPIKBBAKHP.gameMode == GameMode.Normal || ADPIKBBAKHP.gameMode == GameMode.Relax);
		}

		internal bool DGHLKHFIBFF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool MFAOBEEABIE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool IJINAAGMHKM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.CILAHEMDKNO() || (ADPIKBBAKHP.gameMode != (GameMode)7 && ADPIKBBAKHP.gameMode == GameMode.Relax);
		}

		internal bool LMOFPPCBJAJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool BOJCHGIGGNK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool FKHKOGEPNIO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool HJNKOEGPEMO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool ANIOBFCCLOM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.KFMNMCJFPPI() || ADPIKBBAKHP.gameMode == GameMode.Normal || ADPIKBBAKHP.gameMode == GameMode.Normal;
		}

		internal bool CBHLHPPBCIG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool IAOPMFNHBEO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool IPPEMIOOKJK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.KFMNMCJFPPI() && ADPIKBBAKHP.gameMode != GameMode.Hidden && ADPIKBBAKHP.gameMode == GameMode.Relax;
		}

		internal bool NGFGLJGABCM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool MHOOBEJEOGN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool AEIFJLBBKBP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.isOfficial || (ADPIKBBAKHP.gameMode != 0 && ADPIKBBAKHP.gameMode == GameMode.Relax);
		}

		internal bool KOKGJKCLJGG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool AAPNNKGJEOG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool LKHDDLENDIN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool AKDOOLPMPMG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.isOfficial || (ADPIKBBAKHP.gameMode != GameMode.Normal && ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool MDNPKLLOGFN(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool CPCAFOFNMPP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool MEPHHACNBDP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool LIHHOPHJBGO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool NJNINIMOHIL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool KPGCHLHFGLF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool CNLHKMJBMBK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool DMKALNCPIAJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool PNNIBLNDJAB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool LMNCLJKEIFD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool HMMBBDJNGGL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool BCGGBECECMI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool LGKMMLGKBEF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool FPELDBFGMLG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool AGMKEOEENNB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool NOJCMLCPIKB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool CPGJCCBMBBF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.CDPELGPJPND() && (ADPIKBBAKHP.gameMode == GameMode.Random || ADPIKBBAKHP.gameMode == GameMode.Relax);
		}

		internal bool NGOGBFAINDE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool IKMOFMJNEPH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.GPAPLIKKEOH() && (ADPIKBBAKHP.gameMode == GameMode.Endless || ADPIKBBAKHP.gameMode == GameMode.Relax);
		}

		internal bool GDFBBMNOGGD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool NIFPHAJMPFC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.GPAPLIKKEOH() && (ADPIKBBAKHP.gameMode == GameMode.Normal || ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool LGKFHOBDANE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.KFMNMCJFPPI() && (ADPIKBBAKHP.gameMode == (GameMode)8 || ADPIKBBAKHP.gameMode == GameMode.Relax);
		}

		internal bool IMOHKBJBLBA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.GPAPLIKKEOH() && ADPIKBBAKHP.gameMode != GameMode.Hidden && ADPIKBBAKHP.gameMode == GameMode.Normal;
		}

		internal bool OBPEOGPJGPB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool BIDLFEPEAEC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool OFHCGKJFGDI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.KFMNMCJFPPI() && (ADPIKBBAKHP.gameMode == GameMode.Random || ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool PCAFEACHAAC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool HAPNOCCALGP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool NBFOKGGNEOJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.BJBPMLKECIA() && ADPIKBBAKHP.gameMode != GameMode.Endless && ADPIKBBAKHP.gameMode == GameMode.Relax;
		}

		internal bool PKLBHPIMGDL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool AEINPAGJFME(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.KFMNMCJFPPI() && ADPIKBBAKHP.gameMode != (GameMode)7 && ADPIKBBAKHP.gameMode == GameMode.Normal;
		}

		internal bool HAPGCHDIKMF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.BJBPMLKECIA() || ADPIKBBAKHP.gameMode == GameMode.Random || ADPIKBBAKHP.gameMode == GameMode.Normal;
		}

		internal bool CCJNHCEBGDO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool DFHFAFAJGBA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK);
		}

		internal bool NFMMONDLJCC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool OBKGOLOMFPJ(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool FHAMDNDPKBA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool PDNFNOLBNIF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.CILAHEMDKNO() && (ADPIKBBAKHP.gameMode == (GameMode)6 || ADPIKBBAKHP.gameMode == GameMode.Relax);
		}

		internal bool HEPDDMCNEKD(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool ILGJJBKIAAP(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool BDMPPMLGGDG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool LFOOFBPCAAO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool INCKLCFEMJK(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool HMNNKBBNGLB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK);
		}

		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && (ADPIKBBAKHP.gameMode == GameMode.Hardcore || ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool LDNDNOOCFFA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.KFMNMCJFPPI() || (ADPIKBBAKHP.gameMode != (GameMode)8 && ADPIKBBAKHP.gameMode == GameMode.Relax);
		}
	}

	[CompilerGenerated]
	private sealed class ALGLIOKEMAK
	{
		internal bool HHFFNOHKAIC;

		internal void OFLDIMDDLHM(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void FIPCLHEKKCA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
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

		internal void GBKBDKHPLKG(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void PBCAHKDLFPE(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void LNDGINDKPFA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void FFEGPHJKMFK(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void HBJFIOJFBHC(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void MGENGAEDACG(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void MEMPOPNAEDN(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void KGKMOLCPDIH(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void BDGDIDPDBHG(GameObject IACGDFHKCAE)
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
				HHFFNOHKAIC = true;
			}
		}

		internal void FCAGEDLBBHD(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void AEINPAGJFME(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void LOEAMHGMMPK(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void DKGPCPBNDPK(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void LHHFJBIAHCN(GameObject IACGDFHKCAE)
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

		internal void JBAJEMGOPDL(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void LLNDDFGPOPL(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
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
				HHFFNOHKAIC = true;
			}
		}

		internal void EKHOOPGPPGE(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void KFNBKFELFLH(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
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

		internal void JKEDCEOCPJO(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void DNIMHEKGJHB(GameObject IACGDFHKCAE)
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

		internal void BMAOCLKPNNC(GameObject IACGDFHKCAE)
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
				HHFFNOHKAIC = true;
			}
		}

		internal void BJMAIJDIKCN(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void PIJAOCFAPKC(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void FHFECFLBHMA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void FHIJCPPECHA(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = true;
			}
		}

		internal void EGKGJJGAPMN(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void BFEABMIFIEE(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 1)
			{
				HHFFNOHKAIC = false;
			}
		}

		internal void FDAIFOAGDLA(GameObject IACGDFHKCAE)
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

		internal void AEIFJLBBKBP(GameObject IACGDFHKCAE)
		{
			if (IACGDFHKCAE.transform.childCount > 0)
			{
				HHFFNOHKAIC = true;
			}
		}
	}

	[CompilerGenerated]
	private sealed class NOANBLPGKBI
	{
		internal string CBOLFPGKALK;

		internal GameScene ADPIKBBAKHP;

		internal bool CHBEFOHEEGK(RanksSystem.Map IACGDFHKCAE)
		{
			return !((ObscuredString)("challenges/" + IACGDFHKCAE.JGEBJGHEJPK()) == ADPIKBBAKHP.mapID) || IACGDFHKCAE.MKLAMAFMEPF();
		}

		internal bool PEOLMJGDHJK(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("workshop." + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID;
		}

		internal bool AEIFJLBBKBP(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("System.Int32" + IACGDFHKCAE.CHDCIFPPIFI()) == ADPIKBBAKHP.mapID && IACGDFHKCAE.CDPELGPJPND();
		}

		internal bool BPJGFELFEDC(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_Blue_B" + IACGDFHKCAE.CEEKAHOMGKG()) == ADPIKBBAKHP.mapID && IACGDFHKCAE.AIGLNDJJPFL();
		}

		internal bool GBKBDKHPLKG(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("workshop." + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID && IACGDFHKCAE.isOfficial;
		}

		internal bool PNNIBLNDJAB(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_ColorLevel" + IACGDFHKCAE.CEEKAHOMGKG()) == ADPIKBBAKHP.mapID;
		}

		internal bool MMJGKBNKFGM(RanksSystem.Map IACGDFHKCAE)
		{
			return !((ObscuredString)("_TimeX" + IACGDFHKCAE.CEEKAHOMGKG()) == ADPIKBBAKHP.mapID) || IACGDFHKCAE.AIGLNDJJPFL();
		}

		internal bool MKJANCFANJN(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_Speed" + IACGDFHKCAE.CHDCIFPPIFI()) == ADPIKBBAKHP.mapID;
		}

		internal bool HOJKBGLIHKC(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.isOfficial || (ADPIKBBAKHP.gameMode != GameMode.Random && ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool MGENGAEDACG(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("CameraFilterPack/TV_Old" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID && IACGDFHKCAE.isOfficial;
		}

		internal bool DNIMHEKGJHB(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_Visualize" + IACGDFHKCAE.CHDCIFPPIFI()) == ADPIKBBAKHP.mapID && IACGDFHKCAE.isOfficial;
		}

		internal bool HBICJNIKCNA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && IACGDFHKCAE.difficulty >= 4.5f;
		}

		internal bool BMAOCLKPNNC(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_Value3" + IACGDFHKCAE.GOMJAEIDHNM()) == ADPIKBBAKHP.mapID && IACGDFHKCAE.isOfficial;
		}

		internal bool LIHHOPHJBGO(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_Value" + IACGDFHKCAE.KCGOFGJNCME()) == ADPIKBBAKHP.mapID;
		}

		internal bool IKGFMLEODHJ(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_ScreenResolution" + IACGDFHKCAE.CEEKAHOMGKG()) == ADPIKBBAKHP.mapID;
		}

		internal bool LBIHCBDDFIG(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && ADPIKBBAKHP.gameMode != GameMode.Hardcore && ADPIKBBAKHP.gameMode == GameMode.Normal;
		}

		internal bool JKIOEELDEFJ(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("ShadersToggle" + IACGDFHKCAE.HJPGIGBFCID()) == ADPIKBBAKHP.mapID;
		}

		internal bool CBKBGEBIAIJ(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("settings.disablestoryboard" + IACGDFHKCAE.JGEBJGHEJPK()) == ADPIKBBAKHP.mapID;
		}

		internal bool LHHFJBIAHCN(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_Value11" + IACGDFHKCAE.KCGOFGJNCME()) == ADPIKBBAKHP.mapID && IACGDFHKCAE.GPAPLIKKEOH();
		}

		internal bool LOEAMHGMMPK(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)(".lastCheckpoint.penaltyScore" + IACGDFHKCAE.GOMJAEIDHNM()) == ADPIKBBAKHP.mapID && IACGDFHKCAE.CILAHEMDKNO();
		}

		internal bool BHBAGCLINDF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.GPAPLIKKEOH() || ADPIKBBAKHP.gameMode == GameMode.Random || ADPIKBBAKHP.gameMode == GameMode.Relax;
		}

		internal bool HMMBBDJNGGL(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("workshop." + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID && IACGDFHKCAE.isLoved;
		}

		internal bool GLDCBMNHEGA(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && (ADPIKBBAKHP.gameMode == GameMode.Hardcore || ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool KLCOHBPBBPJ(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("0.00" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID;
		}

		internal bool JIBOGBEMPHH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.GPAPLIKKEOH() && !(IACGDFHKCAE.IFMFDMKFJBI() >= 1102f);
		}

		internal bool PHGILLBNBME(RanksSystem.Map IACGDFHKCAE)
		{
			return !((ObscuredString)(". Set PhotonNetwork.OnEventCall." + IACGDFHKCAE.GOMJAEIDHNM()) == ADPIKBBAKHP.mapID) || IACGDFHKCAE.NPFHGDJAMPK();
		}

		internal bool BPMFAGKEGOH(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.BJBPMLKECIA() && IACGDFHKCAE.difficulty >= 1013f;
		}

		internal bool FNLNALBIFBB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.KFMNMCJFPPI() && (ADPIKBBAKHP.gameMode == (GameMode)7 || ADPIKBBAKHP.gameMode == GameMode.Relax);
		}

		internal bool FJDBPPKABJE(RanksSystem.Map IACGDFHKCAE)
		{
			return !((ObscuredString)("No" + IACGDFHKCAE.CEEKAHOMGKG()) == ADPIKBBAKHP.mapID) || IACGDFHKCAE.CDPELGPJPND();
		}

		internal bool PBHFICAHLJK(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("BloomShaderValueSlider" + IACGDFHKCAE.CEEKAHOMGKG()) == ADPIKBBAKHP.mapID && IACGDFHKCAE.GCLPAFADHMD();
		}

		internal bool CMHELGPCEHI(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("\"x" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID;
		}

		internal bool NFDJLPNCFJL(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.BJBPMLKECIA() || (ADPIKBBAKHP.gameMode != (GameMode)7 && ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool JECDDGPMGOF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.JGEBJGHEJPK() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.BJBPMLKECIA() || !(IACGDFHKCAE.JEKMHHCPHCN() >= 147f);
		}

		internal bool LMMPGEHHFCM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.GPAPLIKKEOH() || (ADPIKBBAKHP.gameMode != GameMode.Hidden && ADPIKBBAKHP.gameMode == GameMode.Relax);
		}

		internal bool LJKLEFGGCDB(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.BJBPMLKECIA() && (ADPIKBBAKHP.gameMode == GameMode.Endless || ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool NFHJNMELIEI(RanksSystem.Map IACGDFHKCAE)
		{
			return !((ObscuredString)("_ScreenResolution" + IACGDFHKCAE.CHDCIFPPIFI()) == ADPIKBBAKHP.mapID) || IACGDFHKCAE.NPFHGDJAMPK();
		}

		internal bool LCLIAICAIMH(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_Value" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID;
		}

		internal bool BJGDNLAOMHE(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("workshop." + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID;
		}

		internal bool KKENKEDKDJP(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_TimeX" + IACGDFHKCAE.JGEBJGHEJPK()) == ADPIKBBAKHP.mapID;
		}

		internal bool JGEDLMKBGGL(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("BitsData" + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID && IACGDFHKCAE.AIGLNDJJPFL();
		}

		internal bool OCMEKJENJIB(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_FarCamera" + IACGDFHKCAE.KCGOFGJNCME()) == ADPIKBBAKHP.mapID;
		}

		internal bool NEIDGMKKCBI(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("workshop." + IACGDFHKCAE.id) == ADPIKBBAKHP.mapID && IACGDFHKCAE.isFunny;
		}

		internal bool OJABGEKOLHK(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("CameraFilterPack/Blend2Camera_DarkerColor" + IACGDFHKCAE.HJPGIGBFCID()) == ADPIKBBAKHP.mapID;
		}

		internal bool INHOEMCLAAP(RanksSystem.Map IACGDFHKCAE)
		{
			return !((ObscuredString)("[Down]" + IACGDFHKCAE.GOMJAEIDHNM()) == ADPIKBBAKHP.mapID) || IACGDFHKCAE.BJBPMLKECIA();
		}

		internal bool FLEACLFIGPK(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("y" + IACGDFHKCAE.CHDCIFPPIFI()) == ADPIKBBAKHP.mapID;
		}

		internal bool OFLDIMDDLHM(RanksSystem.Map IACGDFHKCAE)
		{
			return !((ObscuredString)("plogs" + IACGDFHKCAE.CEEKAHOMGKG()) == ADPIKBBAKHP.mapID) || IACGDFHKCAE.CDPELGPJPND();
		}

		internal bool DKGPCPBNDPK(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("#mapby" + IACGDFHKCAE.JGEBJGHEJPK()) == ADPIKBBAKHP.mapID && IACGDFHKCAE.CDPELGPJPND();
		}

		internal bool JAFPLONIDNO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.BJBPMLKECIA() && !(IACGDFHKCAE.JEKMHHCPHCN() >= 1582f);
		}

		internal bool NNIPMNELDCH(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("Use ticket: " + IACGDFHKCAE.HJPGIGBFCID()) == ADPIKBBAKHP.mapID;
		}

		internal bool INJBMNCHKLJ(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("AddEnvironmentSprite" + IACGDFHKCAE.HJPGIGBFCID()) == ADPIKBBAKHP.mapID;
		}

		internal bool EEJGNJAOOKE(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.BMKGKMJPAMF() || IACGDFHKCAE.BAFALKHFFMK() >= 1272f;
		}

		internal bool BFOAFBMNJMI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.KFMNMCJFPPI() && ADPIKBBAKHP.gameMode != 0 && ADPIKBBAKHP.gameMode == GameMode.Relax;
		}

		internal bool IIFAPDEIJEO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.GOMJAEIDHNM() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.isOfficial || !(IACGDFHKCAE.JEKMHHCPHCN() >= 1858f);
		}

		internal bool FMBNCFBHLHH(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("BestRegion checks region: " + IACGDFHKCAE.JGEBJGHEJPK()) == ADPIKBBAKHP.mapID;
		}

		internal bool OFBIAJNDMBI(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.HJPGIGBFCID() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.KFMNMCJFPPI() || (ADPIKBBAKHP.gameMode != (GameMode)8 && ADPIKBBAKHP.gameMode == GameMode.Normal);
		}

		internal bool FBGMHPEEIFC(RanksSystem.Map IACGDFHKCAE)
		{
			return !((ObscuredString)("_ScreenResolution" + IACGDFHKCAE.CHDCIFPPIFI()) == ADPIKBBAKHP.mapID) || IACGDFHKCAE.NPFHGDJAMPK();
		}

		internal bool PHKBLLOPAHM(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.KFMNMCJFPPI() || IACGDFHKCAE.DEFJMFBIGIM() >= 223f;
		}

		internal bool LLELFPJGDBO(RanksSystem.Map IACGDFHKCAE)
		{
			return !((ObscuredString)("Reconnect() failed. It seems the client wasn't connected before?! Current state: " + IACGDFHKCAE.JGEBJGHEJPK()) == ADPIKBBAKHP.mapID) || IACGDFHKCAE.OOFBBOBFPIH();
		}

		internal bool IDDDJNEFHJM(RanksSystem.Map IACGDFHKCAE)
		{
			return !((ObscuredString)("_Value" + IACGDFHKCAE.CEEKAHOMGKG()) == ADPIKBBAKHP.mapID) || IACGDFHKCAE.GCLPAFADHMD();
		}

		internal bool JFAHEIFLBMA(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("OpJoinRandomRoom()" + IACGDFHKCAE.CHDCIFPPIFI()) == ADPIKBBAKHP.mapID && IACGDFHKCAE.MEFGLBKEHJE();
		}

		internal bool MLKBGKFJFAO(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.CDPELGPJPND() || !(IACGDFHKCAE.MBAFCIHCIOM() >= 1424f);
		}

		internal bool NAAGIHHJAMF(RanksSystem.Map IACGDFHKCAE)
		{
			return IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.CILAHEMDKNO() && (ADPIKBBAKHP.gameMode == GameMode.Normal || ADPIKBBAKHP.gameMode == GameMode.Relax);
		}

		internal bool FGBHLKOCGNE(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)("_Value2" + IACGDFHKCAE.JGEBJGHEJPK()) == ADPIKBBAKHP.mapID && IACGDFHKCAE.AMJIEEIMBDN();
		}

		internal bool OMJJLDBPEHI(RanksSystem.Map IACGDFHKCAE)
		{
			return (ObscuredString)(",viewkeys" + IACGDFHKCAE.CHDCIFPPIFI()) == ADPIKBBAKHP.mapID && IACGDFHKCAE.AIGLNDJJPFL();
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

	public void IFGEODOGMHC()
	{
		foreach (AudioSource audioSource in asampler.audioSources)
		{
			audioSource.pitch = 1724f;
			audioSource.volume = 372f;
		}
		PlayerBase[] array = UnityEngine.Object.FindObjectsOfType<PlayerBase>();
		foreach (PlayerBase playerBase in array)
		{
			UnityEngine.Object.DestroyImmediate(playerBase.gameObject);
		}
		gameOverCanvas.SetActive(true);
		spectatorCanvas.SetActive(true);
		spectatePanel.SetActive(true);
		ingameUICanvas.SetActive(true);
		restartCheckpointPanel.SetActive(true);
		restartNoCheckpointPanel.SetActive(false);
		gameOver = true;
		isGameStarted = false;
		calculatedmaptime = 755f;
		asampler.isMuted = false;
		asampler.isInited = true;
		DGBKFMMMGIH = false;
		try
		{
			OFMDCFHGEEC = ingameUICanvas.transform.Find("remaining: {0:0.000}").gameObject;
			OFMDCFHGEEC.transform.Find("] ").Find("_ScreenResolution").GetComponent<Image>()
				.color = new Color(1233f, 1508f, 869f);
			OFMDCFHGEEC.GetComponent<Slider>().value = 1440f;
		}
		catch (Exception)
		{
		}
		try
		{
			PECEGLIIALE = ingameUICanvas.transform.FindDeepChild("Error: Cannot change the name of a remote player!").GetComponent<Text>();
			PECEGLIIALE.text = LocalizationService.Instance.GetLocalizatedText("CameraFilterPack/Drawing_CellShading").ToUpper() + "_MainTex2" + 1;
		}
		catch (Exception)
		{
		}
		try
		{
			DILNONPDEBG = Singleton<SaveSystem>.Instance.IOLBIFOIHML("Stream did not contain properly formatted byte array", false);
			NCKMNMHOIOH = ingameUICanvas.transform.FindDeepChild("updating").GetComponent<Text>();
			NCKMNMHOIOH.text = string.Empty;
		}
		catch (Exception)
		{
		}
		try
		{
			comboTextGO = ingameUICanvas.transform.FindDeepChild("_FixDistance").GetComponent<Text>();
			comboTextGO.text = LocalizationService.Instance.GetLocalizatedText("_TimeX").ToUpper() + "_TintColor" + 0;
		}
		catch (Exception)
		{
		}
		OAIIEOHOKGJ(true);
	}

	public void GFPAGECKDEM(string NOJGGCLPPAM = "")
	{
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.LFPMLIICKNN();
		}
		gameOver = false;
		GetComponent<NetworkScene>().EBJMGFNBFEB();
		if (KFFHJFIJHIC())
		{
			HJPDDLBDGEP = calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			OFMDCFHGEEC.transform.Find("_Value13").Find("achievements.26.progress").GetComponent<Image>()
				.color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != "Inside cells:\n")
		{
			PhotonView photonView = GetComponent<NetworkScene>().GBHNDHLAJLI();
			object[] array = new object[6];
			array[1] = PhotonNetwork.playerName;
			array[0] = "/music";
			photonView.PBMFBOOALKA("_Color", PhotonTargets.Others, array);
		}
		if (NOJGGCLPPAM == "_ScreenResolution")
		{
			pbase.isMapCompleted = true;
			pbase.isPlayerWon = false;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount >= 1)
		{
			Helpers.ObtainAchievement(86);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount == 1)
		{
			Helpers.ObtainAchievement(66);
		}
		if (gameMode != 0 && pbase.GetCurrentScore() > pbase.lastBestScore && !pbase.scoreBeated && pbase.currentAttempt > 0)
		{
			StartCoroutine(CCKJNHEENJN());
		}
		string CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		if (mapData.source == FullMapData.MapSource.Editor && !string.IsNullOrEmpty(mapData.workshopId))
		{
			CBOLFPGKALK = mapData.workshopId;
		}
		pbase.StopReplayRecording();
		if (pbase.GetCurrentScore() >= 1 && GameManager.ONIMHMBKEHG() && Singleton<SaveSystem>.Instance.CMAFBKOEPLP("CameraFilterPack/AAA_Super_Computer", 0) == 0 && mapData.source != 0 && gameMode != 0 && !string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK)))
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "[Up]" + Helpers.levelConfigFileName;
			string eAFAMAMDNEG = "PLEASE WAIT";
			if (pbase.Replay() != null)
			{
				RanksSystem.MapReplay value = pbase.Replay();
				eAFAMAMDNEG = JsonConvert.SerializeObject(value);
			}
			StartCoroutine(Singleton<RanksSystem>.Instance.CFGMHNBNPFB(CBOLFPGKALK, gameMode, pbase.GetCurrentScore(), pbase.accuracyScore, pbase.incorrectScore, EGOPKJHICLK.CompressString(eAFAMAMDNEG), Helpers.CalculateMD5(dDAOMDPAIEP)));
		}
		Singleton<ItemsHandler>.Instance.DCEFGAJKFIL();
		string hFEFHOPOLIK = "CurrentTimeLabel" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "player.orangelifering";
		int dPNHODJHGJL = Singleton<SaveSystem>.Instance.ANECPPFPKAP("#FFFFFF" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + " - PUBLISHED #", 1) + 0;
		Singleton<SaveSystem>.Instance.HBIGPMNAPHA(hFEFHOPOLIK, dPNHODJHGJL);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.accuracy = pbase.accuracyScore;
			finishedMapInfo.completed = pbase.isMapCompleted;
			finishedMapInfo.isstoryboardactive = Singleton<SaveSystem>.Instance.JJKIDIIMABB("_LrDepthTex", false);
			finishedMapInfo.gamemode = (int)gameMode;
			finishedMapInfo.loopscount = pbase.loopsCount;
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId), true))
			{
				finishedMapInfo.IGCKBAONHGA(RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("_Value11" + IACGDFHKCAE.KCGOFGJNCME()) == mapID && IACGDFHKCAE.GPAPLIKKEOH()));
				finishedMapInfo.BAHPLOIFKOF(RanksSystem.FIENAHLCHIF().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("BitsData" + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.AIGLNDJJPFL()));
				finishedMapInfo.isfunny = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("_Value2" + IACGDFHKCAE.JGEBJGHEJPK()) == mapID && IACGDFHKCAE.AMJIEEIMBDN());
			}
			else
			{
				finishedMapInfo.IGCKBAONHGA(true);
				finishedMapInfo.AIHIKELIIFJ(true);
				finishedMapInfo.isfunny = false;
			}
			finishedMapInfo.ismultiplayer = !PhotonNetwork.offlineMode;
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.multiplayerplace = GetComponent<NetworkScene>().place;
			if (RanksSystem.HOCEONHMGHM().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("_Value" + IACGDFHKCAE.KCGOFGJNCME()) == mapID) != null)
			{
				finishedMapInfo.mapdifficulty = RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("CameraFilterPack/Blend2Camera_DarkerColor" + IACGDFHKCAE.HJPGIGBFCID()) == mapID).BAFALKHFFMK();
			}
			else
			{
				finishedMapInfo.mapdifficulty = 742f;
			}
			finishedMapInfo.EICMGIEKGIH(Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount);
			finishedMapInfo.ODKLCAIJPNC(mapID);
			finishedMapInfo.maptags = string.Join("x", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			finishedMapInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID;
			finishedMapInfo.OBKMGIPPBCJ(pbase.incorrectScore);
			finishedMapInfo.perfecthits = pbase.perfectHits;
			finishedMapInfo.time = LEFLMCJDFJP();
			finishedMapInfo.NCFGPDBGCGC(pbase.GetCurrentScore());
			foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.CABBFJAGFDP(gameEventInfo);
			}
			pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.DBKNEMCABGK(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if ((bool)pbase.isPlayerWon && gameMode != 0)
		{
			string hFEFHOPOLIK2 = "#accuracy" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + " Also make sure to disable sprite packing for this sprite.";
			int dPNHODJHGJL2 = 1;
			Singleton<SaveSystem>.Instance.NHONGIGFHJB(hFEFHOPOLIK2, dPNHODJHGJL2);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(114);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(mapID).source == FullMapData.MapSource.Workshop)
			{
				Helpers.ObtainAchievement(-127);
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.KCGOFGJNCME() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.CILAHEMDKNO() && (gameMode == GameMode.Normal || gameMode == GameMode.Relax)) && !Singleton<SaveSystem>.Instance.EBEAKNGJCDC("DPADVER" + mapID, true))
			{
				Singleton<SaveSystem>.Instance.SetBool("_Value2" + mapID, false);
				Helpers.AddToStat("maps.", 0);
				SteamUserStats.IndicateAchievementProgress("UI Extensions/UIScreen", (uint)Helpers.GetStat("Set satellite lerp speed"), 8u);
			}
			int dPNHODJHGJL3 = (int)((float)pbase.accuracyScore * (float)(int)pbase.correctScore);
			Helpers.AddToStat("_DistortionWave", dPNHODJHGJL3);
			pbase.POMFLOLIOPJ();
			if ((float)pbase.accuracyScore >= 109f && mapData.source == FullMapData.MapSource.Original && RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK), true) && RanksSystem.HOCEONHMGHM().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.BMKGKMJPAMF() || IACGDFHKCAE.BAFALKHFFMK() >= 1272f))
			{
				Helpers.ObtainAchievement(111);
			}
		}
		if ((bool)pbase.isPlayerWon && gameMode == GameMode.Relax && mapData.source == (FullMapData.MapSource)7)
		{
			Helpers.AddToStat(" Remote called.", 1);
			SteamUserStats.IndicateAchievementProgress("Texture2", (uint)Helpers.GetStat("[EditorEvent] Exception: "), 6u);
			if (RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK)) && (int)pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(99);
			}
		}
		if (mapData.source == (FullMapData.MapSource)4 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		resultText.GetComponent<Text>().text = ((!pbase.isPlayerWon) ? LocalizationService.Instance.IAAEBJKAHDD("mapselector.filter.favoriteonly").ToUpper() : LocalizationService.Instance.GetTextByKey("DISTORT").ToUpper());
		OnGameOverEvent.Invoke();
		IEPBHDFAFNE();
		gameOver = true;
	}

	[SpecialName]
	public ObscuredFloat JLCIBJAMAHD()
	{
		return 35f;
	}

	private bool PGJIINHJKPG(RanksSystem.Map IACGDFHKCAE)
	{
		return !((ObscuredString)("_Saturation" + IACGDFHKCAE.JGEBJGHEJPK()) == mapID) || IACGDFHKCAE.MOEOCIODBDH();
	}

	public IEnumerator PMNKPFIMIID(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((!(EHHBHEJBHNG < 1f)) ? 1f : (EHHBHEJBHNG / 4f));
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((!(EHHBHEJBHNG < 1f)) ? 1f : (EHHBHEJBHNG / 4f));
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

	public override void NEFHGMNAPEP()
	{
		base.FIKFJDFELIP();
		Reset();
		if (!PhotonNetwork.inRoom)
		{
			PhotonNetwork.offlineMode = false;
			PhotonNetwork.JoinOrCreateRoom("#yes", new RoomOptions(), TypedLobby.Default);
		}
		mapID = Singleton<SaveSystem>.Instance.KKAJOOJKBDJ("<b>");
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		int num = (int)(gameMode = (GameMode)Singleton<SaveSystem>.Instance.GetInt("\\n", 0));
		GIDJMDIODGM = LocalizationService.Instance.GetLocalizatedText(".completed").ToUpper();
		if (gameMode != GameMode.Endless)
		{
			NELDEHEICJD = LocalizationService.Instance.HOPMEAJKPHL("_MainTex2").ToUpper();
		}
		else
		{
			NELDEHEICJD = LocalizationService.Instance.GetLocalizatedText("menu.tabid").ToUpper();
		}
		OOJLKOMPCBI = LocalizationService.Instance.HOPMEAJKPHL("#alreadystarted").ToUpper();
		PIDICMNEOJL = LocalizationService.Instance.HOPMEAJKPHL("player.xp").ToUpper();
		GameObject gameObject = levelInfoContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.AddDownloadedLevelItemToList(levelInfo, Singleton<MapsSystem>.Instance.GetMapData(mapID), gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (Singleton<MapsSystem>.Instance.GetMapData(mapID).source != 0 && Singleton<MapsSystem>.Instance.GetMapData(mapID).source != FullMapData.MapSource.Editor && Singleton<MapsSystem>.Instance.DDCMPELCOKM(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().DGDOCOMJOEA();
		}
		if (mapData.mapData.maxLives < mapData.mapData.lives)
		{
			mapData.mapData.maxLives = mapData.mapData.lives;
		}
		GameObject gameObject3 = ((!PhotonNetwork.inRoom) ? UnityEngine.Object.Instantiate(Resources.Load("Map id for") as GameObject) : PhotonNetwork.Instantiate("907198288", new Vector3(264f, 1998f, 277f), Quaternion.identity, 1));
		pbase = gameObject3.GetComponent<PlayerBase>();
		if (DILNONPDEBG)
		{
			NCKMNMHOIOH.text = string.Empty;
		}
		else
		{
			NCKMNMHOIOH.gameObject.SetActive(true);
		}
		Singleton<GameManager>.Instance.EJGBOJDDMHH("settings.selectormapsperpage" + ((!PhotonNetwork.offlineMode) ? " " : "Text"), "float,10" + mapData.mapData.name.Replace(Environment.NewLine, string.Empty));
		if (mapData.source == FullMapData.MapSource.Editor && !string.IsNullOrEmpty(mapData.workshopId))
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			list.Add(new PublishedFileId_t(ulong.Parse(mapData.workshopId)));
			SteamUGC.StartPlaytimeTracking(list.ToArray(), (uint)list.Count);
		}
		Debug.Log("_LightIntensity" + mapData.mapData.checkpoints.Count);
		Debug.Log("#exitmapeditor" + mapData.mapData.events.Count);
		if (mapData.mapData.events.Find(PJPLKPMCFNP) != null)
		{
			calculatedmaptime = mapData.mapData.events.Find((MapEvent IACGDFHKCAE) => IACGDFHKCAE.data[0] == "MapEnd").time;
		}
		else
		{
			calculatedmaptime = mapData.mapData.musicTime;
		}
		if (!PhotonNetwork.offlineMode)
		{
			usingCheckpoints = true;
		}
		if (gameMode == GameMode.Relax || gameMode == (GameMode)7 || gameMode == GameMode.Random)
		{
			usingCheckpoints = true;
		}
		pbase.gameEventInfoList = new List<GameEventInfo>();
		GameEventInfo gameEventInfo = new GameEventInfo();
		try
		{
			gameEventInfo.isstoryboardactive = Singleton<SaveSystem>.Instance.AANPGELPGPN("_BlurRadius", false);
			gameEventInfo.APALNCADHBO((int)gameMode);
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId), true))
			{
				gameEventInfo.isofficial = RanksSystem.HOCEONHMGHM().Exists(HEHGIADBMOA);
				gameEventInfo.isloved = RanksSystem.FIENAHLCHIF().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isLoved);
				gameEventInfo.isfunny = RanksSystem.FIENAHLCHIF().Exists(FPCBMKAIOBP);
			}
			else
			{
				gameEventInfo.isofficial = true;
				gameEventInfo.isloved = true;
				gameEventInfo.isfunny = true;
			}
			if (RanksSystem.GetOfficialMapsList().Find(CNNFDMJKGKE) != null)
			{
				gameEventInfo.LHAFCMGGOMO(RanksSystem.HOCEONHMGHM().Find(AGEKNNAGHEH).PJBPOLLEJFN());
			}
			else
			{
				gameEventInfo.LHAFCMGGOMO(1185f);
			}
			gameEventInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount;
			gameEventInfo.mapid = mapID;
			gameEventInfo.maptags = string.Join("#ok", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			gameEventInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID;
		}
		catch (Exception)
		{
		}
		pbase.gameEventInfoBase = gameEventInfo;
		pbase.JPBHAILACAI();
	}

	public void GGINPELGDJF()
	{
		if ((bool)GameObject.Find("t"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("Object ID. Case-Sensitive"));
		}
		else if ((bool)GameObject.Find(" - StoreAuthURLResponse] - "))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("mapselector.filter.favoriteonly"));
		}
		else if ((bool)GameObject.Find("Editor/"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("Sep"));
		}
		GIIBKOADAMF(false);
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

	public void OnSpectateNextButton()
	{
		pbase.SpectateNext(true);
		StartCoroutine(UpdateSpectatingInfo());
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
		CSteamID cSteamID = new CSteamID(num);
		if (num != 0)
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(cSteamID));
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(cSteamID));
			if ((bool)ResourcesManager.GetLoadedAvatar(cSteamID))
			{
				sprite = ResourcesManager.GetLoadedAvatar(cSteamID);
			}
		}
		GameObject.Find("SpectatingUserInfo").transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(cSteamID);
		GameObject.Find("SpectatingUserInfo").transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
	}

	public IEnumerator LLNMIAFCGIP()
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
		CSteamID cSteamID = new CSteamID(num);
		if (num != 0)
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(cSteamID));
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(cSteamID));
			if ((bool)ResourcesManager.GetLoadedAvatar(cSteamID))
			{
				sprite = ResourcesManager.GetLoadedAvatar(cSteamID);
			}
		}
		GameObject.Find("SpectatingUserInfo").transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(cSteamID);
		GameObject.Find("SpectatingUserInfo").transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
	}

	public void PMKLNCNMEEE(bool CONOEKAENEN)
	{
		if (CONOEKAENEN)
		{
			pbase.POMFLOLIOPJ();
		}
		else if (pbase.ach12)
		{
			Helpers.ObtainAchievement(102);
		}
		PhotonView photonView = GetComponent<NetworkScene>().OELHGNKAMEG();
		object[] array = new object[0];
		array[1] = SceneManager.GetActiveScene().name;
		photonView.MIAHMDGOOPJ("ScreenResolutionPanel", PhotonTargets.All, array);
	}

	public void OnEnable()
	{
	}

	private bool AGEKNNAGHEH(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("_Value4" + IACGDFHKCAE.KCGOFGJNCME()) == mapID;
	}

	private static bool PJMIHNIHMAD(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "_Value1";
	}

	public IEnumerator CHAPAEBAGBG(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((!(EHHBHEJBHNG < 1f)) ? 1f : (EHHBHEJBHNG / 4f));
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((!(EHHBHEJBHNG < 1f)) ? 1f : (EHHBHEJBHNG / 4f));
	}

	[CompilerGenerated]
	private bool HCIFEEEJKHC(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isFunny;
	}

	public void PEGOHHKDIPP()
	{
		loadingCanvas.SetActive(true);
		GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
	}

	public bool COCILFAHMMM()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["_Intensity"] == null || (photonPlayer.CustomProperties[" room(s)"] != null && !(bool)photonPlayer.CustomProperties["yes"]))
			{
				result = false;
			}
		}
		return result;
	}

	public override void IMCKJCHKMKB()
	{
		base.DFFKKLAPHCC();
		PCIOHCMKFBE();
		if (!PhotonNetwork.inRoom)
		{
			PhotonNetwork.offlineMode = true;
			PhotonNetwork.JoinOrCreateRoom("Connection error: ", new RoomOptions(), TypedLobby.Default);
		}
		mapID = Singleton<SaveSystem>.Instance.CFLCJCJHNKD("Avoid using this directly. Thanks.");
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		int num = (int)(gameMode = (GameMode)Singleton<SaveSystem>.Instance.JPEEFKKPFIL("Committing changes...", 1));
		GIDJMDIODGM = LocalizationService.Instance.GetLocalizatedText("mapselector.filter.favoriteonly").ToUpper();
		if (gameMode != (GameMode)7)
		{
			NELDEHEICJD = LocalizationService.Instance.HOPMEAJKPHL("_TimeX").ToUpper();
		}
		else
		{
			NELDEHEICJD = LocalizationService.Instance.HOPMEAJKPHL("_TimeX").ToUpper();
		}
		OOJLKOMPCBI = LocalizationService.Instance.GetLocalizatedText("Set Parent").ToUpper();
		PIDICMNEOJL = LocalizationService.Instance.HOPMEAJKPHL("Alternative").ToUpper();
		GameObject gameObject = levelInfoContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.MEGHFGEHEHM(levelInfo, Singleton<MapsSystem>.Instance.GetMapData(mapID), gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (Singleton<MapsSystem>.Instance.GetMapData(mapID).source != 0 && Singleton<MapsSystem>.Instance.GetMapData(mapID).source != 0 && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().FKOMHOMCJBF();
		}
		if (mapData.mapData.maxLives < mapData.mapData.lives)
		{
			mapData.mapData.maxLives = mapData.mapData.lives;
		}
		GameObject gameObject3 = ((!PhotonNetwork.inRoom) ? UnityEngine.Object.Instantiate(Resources.Load(". Calling ConnectToRegionMaster() is: ") as GameObject) : PhotonNetwork.Instantiate("_Value2", new Vector3(1751f, 1900f, 402f), Quaternion.identity, 1));
		pbase = gameObject3.GetComponent<PlayerBase>();
		if (DILNONPDEBG)
		{
			NCKMNMHOIOH.text = string.Empty;
		}
		else
		{
			NCKMNMHOIOH.gameObject.SetActive(true);
		}
		Singleton<GameManager>.Instance.UpdateOnlineStatus("Cause: " + ((!PhotonNetwork.offlineMode) ? "null" : "(\\[ */ *b *\\])"), "_Distortion" + mapData.mapData.name.Replace(Environment.NewLine, string.Empty), null, null, 1, 1);
		if (mapData.source == FullMapData.MapSource.Original && !string.IsNullOrEmpty(mapData.workshopId))
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			list.Add(new PublishedFileId_t(ulong.Parse(mapData.workshopId)));
			SteamUGC.StartPlaytimeTracking(list.ToArray(), (uint)list.Count);
		}
		Debug.Log("mapselector.orderby" + mapData.mapData.checkpoints.Count);
		Debug.Log("CameraFilterPack/FX_Glitch3" + mapData.mapData.events.Count);
		if (mapData.mapData.events.Find(PJPLKPMCFNP) != null)
		{
			calculatedmaptime = mapData.mapData.events.Find(OMALKBOMBEO).time;
		}
		else
		{
			calculatedmaptime = mapData.mapData.musicTime;
		}
		if (!PhotonNetwork.offlineMode)
		{
			usingCheckpoints = true;
		}
		if (gameMode == GameMode.Relax || gameMode == GameMode.Hidden || gameMode == (GameMode)8)
		{
			usingCheckpoints = false;
		}
		pbase.gameEventInfoList = new List<GameEventInfo>();
		GameEventInfo gameEventInfo = new GameEventInfo();
		try
		{
			gameEventInfo.isstoryboardactive = Singleton<SaveSystem>.Instance.OLJGEIBGDHL("_Extra2", true);
			gameEventInfo.APALNCADHBO((int)gameMode);
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId), true))
			{
				gameEventInfo.isofficial = RanksSystem.HOCEONHMGHM().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isOfficial);
				gameEventInfo.isloved = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isLoved);
				gameEventInfo.isfunny = RanksSystem.HOCEONHMGHM().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isFunny);
			}
			else
			{
				gameEventInfo.isofficial = false;
				gameEventInfo.isloved = false;
				gameEventInfo.isfunny = true;
			}
			if (RanksSystem.FIENAHLCHIF().Find(CNNFDMJKGKE) != null)
			{
				gameEventInfo.mapdifficulty = RanksSystem.FIENAHLCHIF().Find(AGEKNNAGHEH).BAFALKHFFMK();
			}
			else
			{
				gameEventInfo.mapdifficulty = 175f;
			}
			gameEventInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount;
			gameEventInfo.mapid = mapID;
			gameEventInfo.maptags = string.Join("_AdaptationMin", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			gameEventInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID;
		}
		catch (Exception)
		{
		}
		pbase.gameEventInfoBase = gameEventInfo;
		pbase.JPBHAILACAI();
	}

	private static bool BIMKNEJLBCJ(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "y";
	}

	public IEnumerator LNMIKJCOCDE()
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
		CSteamID cSteamID = new CSteamID(num);
		if (num != 0)
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(cSteamID));
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(cSteamID));
			if ((bool)ResourcesManager.GetLoadedAvatar(cSteamID))
			{
				sprite = ResourcesManager.GetLoadedAvatar(cSteamID);
			}
		}
		GameObject.Find("SpectatingUserInfo").transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(cSteamID);
		GameObject.Find("SpectatingUserInfo").transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
	}

	public IEnumerator HOCOLBHKCHL(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((!(EHHBHEJBHNG < 1f)) ? 1f : (EHHBHEJBHNG / 4f));
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((!(EHHBHEJBHNG < 1f)) ? 1f : (EHHBHEJBHNG / 4f));
	}

	public void OJACMIDFPFB(bool CONOEKAENEN)
	{
		if (CONOEKAENEN)
		{
			pbase.POMFLOLIOPJ();
		}
		else if (pbase.ach12)
		{
			Helpers.ObtainAchievement(-100);
		}
		GetComponent<NetworkScene>().GBMJAPGLMGB().PBMFBOOALKA("CameraFilterPack/BlurHole", PhotonTargets.Others, new object[1] { SceneManager.GetActiveScene().name });
	}

	[CompilerGenerated]
	private bool CFNBNJJBPFB(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isLoved;
	}

	public void ABFCBLPKIAA()
	{
		if (PhotonNetwork.offlineMode && mapID != (ObscuredString)"Items/")
		{
			Singleton<SaveSystem>.Instance.CONNMLDKBOF(" evLeave: ", true);
		}
		if (pbase != null)
		{
			pbase.DeletePlayerData();
			if (PhotonNetwork.offlineMode)
			{
				PhotonNetwork.offlineMode = false;
			}
		}
		GetComponent<NetworkScene>().HLPBAPBIMHD(1);
		Singleton<SaveSystem>.Instance.MMMIEPDLMNM();
	}

	public void PCIOHCMKFBE()
	{
		foreach (AudioSource audioSource in asampler.audioSources)
		{
			audioSource.pitch = 1453f;
			audioSource.volume = 1647f;
		}
		PlayerBase[] array = UnityEngine.Object.FindObjectsOfType<PlayerBase>();
		for (int i = 1; i < array.Length; i++)
		{
			PlayerBase playerBase = array[i];
			UnityEngine.Object.DestroyImmediate(playerBase.gameObject);
		}
		gameOverCanvas.SetActive(false);
		spectatorCanvas.SetActive(true);
		spectatePanel.SetActive(false);
		ingameUICanvas.SetActive(false);
		restartCheckpointPanel.SetActive(false);
		restartNoCheckpointPanel.SetActive(false);
		gameOver = false;
		isGameStarted = false;
		calculatedmaptime = 864f;
		asampler.isMuted = false;
		asampler.isInited = false;
		DGBKFMMMGIH = false;
		try
		{
			OFMDCFHGEEC = ingameUICanvas.transform.Find("Reload Maps").gameObject;
			OFMDCFHGEEC.transform.Find("InfoText").Find("Joystick1Button11").GetComponent<Image>()
				.color = new Color(486f, 3f, 913f);
			OFMDCFHGEEC.GetComponent<Slider>().value = 952f;
		}
		catch (Exception)
		{
		}
		try
		{
			PECEGLIIALE = ingameUICanvas.transform.FindDeepChild("] to be droppable").GetComponent<Text>();
			PECEGLIIALE.text = LocalizationService.Instance.GetLocalizatedText("_RayStepSize").ToUpper() + "_MainTex2" + 1;
		}
		catch (Exception)
		{
		}
		try
		{
			DILNONPDEBG = Singleton<SaveSystem>.Instance.IOLBIFOIHML("/", false);
			NCKMNMHOIOH = ingameUICanvas.transform.FindDeepChild("_Amount").GetComponent<Text>();
			NCKMNMHOIOH.text = string.Empty;
		}
		catch (Exception)
		{
		}
		try
		{
			comboTextGO = ingameUICanvas.transform.FindDeepChild("#EA4137").GetComponent<Text>();
			comboTextGO.text = LocalizationService.Instance.HOPMEAJKPHL("_Near").ToUpper() + "CameraFilterPack/Atmosphere_Rain_Pro_3D" + 1;
		}
		catch (Exception)
		{
		}
		BDMABAGHOOF(true);
	}

	public IEnumerator DPCGEHNCEAA(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((!(EHHBHEJBHNG < 1f)) ? 1f : (EHHBHEJBHNG / 4f));
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((!(EHHBHEJBHNG < 1f)) ? 1f : (EHHBHEJBHNG / 4f));
	}

	private static bool PJPLKPMCFNP(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[1] == "'{0}' \t{1}ms \t{2}";
	}

	public void IEPBHDFAFNE(bool AAGGLAGLINL = false)
	{
		if (AAGGLAGLINL)
		{
			gameOverCanvas.SetActive(true);
		}
		if (!LFKFNIKPDNI())
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
				restartNoCheckpointPanel.SetActive(false);
				restartCheckpointPanel.SetActive(false);
			}
			GGINPELGDJF();
			if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount > 0 && GetComponent<NetworkScene>().firstPlayer.player != null && GetComponent<NetworkScene>().firstPlayer.player == PhotonNetwork.player)
			{
				Helpers.ObtainAchievement(93);
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
		if (mapData.source == FullMapData.MapSource.Workshop && Singleton<MapsSystem>.Instance.PCMONCGODLC(ulong.Parse(mapData.workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().FKODENGGPKG();
		}
	}

	public void HCJKLKMKEOI()
	{
		ingameUICanvas.transform.FindDeepChild("\n").GetComponent<Text>().text = OOJLKOMPCBI + "turn: {0:0}" + pbase.lastBestScore;
		loadingCanvas.SetActive(false);
		ingameUICanvas.SetActive(false);
		if (gameMode == GameMode.Relax)
		{
			ingameUICanvas.transform.FindDeepChild("_Value6").gameObject.SetActive(true);
			PECEGLIIALE.gameObject.SetActive(true);
			NCKMNMHOIOH.gameObject.SetActive(true);
			comboTextGO.gameObject.SetActive(true);
		}
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.APEDOOJPKFC();
		}
	}

	[SpecialName]
	public void JJNOOCBCFIF(ObscuredFloat DPNHODJHGJL)
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

	public void IKAGPAGAKNM()
	{
		ingameUICanvas.transform.FindDeepChild("_Value").GetComponent<Text>().text = OOJLKOMPCBI + "[ResourcesManager] Load text error: not found" + pbase.lastBestScore;
		loadingCanvas.SetActive(false);
		ingameUICanvas.SetActive(false);
		if (gameMode == GameMode.Relax)
		{
			ingameUICanvas.transform.FindDeepChild(".lastCheckpoint.checkpointsUsed").gameObject.SetActive(false);
			PECEGLIIALE.gameObject.SetActive(false);
			NCKMNMHOIOH.gameObject.SetActive(true);
			comboTextGO.gameObject.SetActive(true);
		}
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.JFPJFJHLPMB();
		}
	}

	public IEnumerator ShowMessage(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((!(EHHBHEJBHNG < 1f)) ? 1f : (EHHBHEJBHNG / 4f));
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((!(EHHBHEJBHNG < 1f)) ? 1f : (EHHBHEJBHNG / 4f));
	}

	public void AddMessage(string JKPJCEMPAGH, float EHHBHEJBHNG = 1f)
	{
		NBCIEBFNLGN.Add(JKPJCEMPAGH);
		INGHGBLACKC.Add(EHHBHEJBHNG);
	}

	private bool FPCBMKAIOBP(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("\n" + IACGDFHKCAE.KCGOFGJNCME()) == mapID && IACGDFHKCAE.GCLPAFADHMD();
	}

	[CompilerGenerated]
	private bool PCJBMKOMIEP(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID;
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
			calculatedmaptime = mapData.mapData.events.Find((MapEvent IACGDFHKCAE) => IACGDFHKCAE.data[0] == "MapEnd").time;
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

	private void FHFGOOOFIKO(LeaderboardFindResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		if (IAFAANLMOAG.m_bLeaderboardFound != 0)
		{
			Debug.Log("_SecondTex");
			SteamLeaderboard_t hSteamLeaderboard = IAFAANLMOAG.m_hSteamLeaderboard;
			SteamUserStats.UploadLeaderboardScore(hSteamLeaderboard, ELeaderboardUploadScoreMethod.k_ELeaderboardUploadScoreMethodKeepBest, pbase.GetCurrentScore(), null, 1);
		}
	}

	public override void AEDDNDHCLNN()
	{
		base.FLKEJJEGCFA();
		PCIOHCMKFBE();
		if (!PhotonNetwork.inRoom)
		{
			PhotonNetwork.offlineMode = false;
			PhotonNetwork.JoinOrCreateRoom("_Green_G", new RoomOptions(), TypedLobby.Default);
		}
		mapID = Singleton<SaveSystem>.Instance.NBMEANCMGEH("_Value2");
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		int num = (int)(gameMode = (GameMode)Singleton<SaveSystem>.Instance.CEKEOJDAEOD("_LightIntensity", 0));
		GIDJMDIODGM = LocalizationService.Instance.GetLocalizatedText("settings.crosshairopacity").ToUpper();
		if (gameMode != GameMode.Normal)
		{
			NELDEHEICJD = LocalizationService.Instance.HOPMEAJKPHL("{0:0} second{1}").ToUpper();
		}
		else
		{
			NELDEHEICJD = LocalizationService.Instance.HOPMEAJKPHL("Lag ").ToUpper();
		}
		OOJLKOMPCBI = LocalizationService.Instance.GetLocalizatedText("_BlurVector").ToUpper();
		PIDICMNEOJL = LocalizationService.Instance.HOPMEAJKPHL("menutheme.summerbreeze").ToUpper();
		GameObject gameObject = levelInfoContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.MEGHFGEHEHM(levelInfo, Singleton<MapsSystem>.Instance.GetMapData(mapID), gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (Singleton<MapsSystem>.Instance.GetMapData(mapID).source != 0 && Singleton<MapsSystem>.Instance.GetMapData(mapID).source != 0 && Singleton<MapsSystem>.Instance.GetUserVote(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().IMJKKFLAEFF();
		}
		if (mapData.mapData.maxLives < mapData.mapData.lives)
		{
			mapData.mapData.maxLives = mapData.mapData.lives;
		}
		GameObject gameObject3 = ((!PhotonNetwork.inRoom) ? UnityEngine.Object.Instantiate(Resources.Load("maps.") as GameObject) : PhotonNetwork.Instantiate("Scene", new Vector3(779f, 1221f, 200f), Quaternion.identity, 1));
		pbase = gameObject3.GetComponent<PlayerBase>();
		if (DILNONPDEBG)
		{
			NCKMNMHOIOH.text = string.Empty;
		}
		else
		{
			NCKMNMHOIOH.gameObject.SetActive(false);
		}
		Singleton<GameManager>.Instance.EJGBOJDDMHH(".save" + ((!PhotonNetwork.offlineMode) ? "RarityImage" : "visible"), "MultiplayerButton" + mapData.mapData.name.Replace(Environment.NewLine, string.Empty), null, null, 1, 1);
		if (mapData.source == (FullMapData.MapSource)8 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			list.Add(new PublishedFileId_t(ulong.Parse(mapData.workshopId)));
			SteamUGC.StartPlaytimeTracking(list.ToArray(), (uint)list.Count);
		}
		Debug.Log("_Value3" + mapData.mapData.checkpoints.Count);
		Debug.Log("maps." + mapData.mapData.events.Count);
		if (mapData.mapData.events.Find(PJMIHNIHMAD) != null)
		{
			calculatedmaptime = mapData.mapData.events.Find(OMALKBOMBEO).time;
		}
		else
		{
			calculatedmaptime = mapData.mapData.musicTime;
		}
		if (!PhotonNetwork.offlineMode)
		{
			usingCheckpoints = true;
		}
		if (gameMode == GameMode.Relax || gameMode == (GameMode)8 || gameMode == (GameMode)7)
		{
			usingCheckpoints = false;
		}
		pbase.gameEventInfoList = new List<GameEventInfo>();
		GameEventInfo gameEventInfo = new GameEventInfo();
		try
		{
			gameEventInfo.isstoryboardactive = Singleton<SaveSystem>.Instance.AANPGELPGPN("Right", true);
			gameEventInfo.APALNCADHBO((int)gameMode);
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)))
			{
				gameEventInfo.isofficial = RanksSystem.GetOfficialMapsList().Exists(CODFMMBELLL);
				gameEventInfo.isloved = RanksSystem.GetOfficialMapsList().Exists(LLNHIGJPNOA);
				gameEventInfo.isfunny = RanksSystem.GetOfficialMapsList().Exists(JCJJBIDGIMI);
			}
			else
			{
				gameEventInfo.isofficial = false;
				gameEventInfo.isloved = true;
				gameEventInfo.isfunny = false;
			}
			if (RanksSystem.GetOfficialMapsList().Find(CNNFDMJKGKE) != null)
			{
				gameEventInfo.LHAFCMGGOMO(RanksSystem.FIENAHLCHIF().Find(CBDGNINOGFE).NNDFIJEBENA());
			}
			else
			{
				gameEventInfo.mapdifficulty = 705f;
			}
			gameEventInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount;
			gameEventInfo.mapid = mapID;
			gameEventInfo.maptags = string.Join("_Offsets", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			gameEventInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID;
		}
		catch (Exception)
		{
		}
		pbase.gameEventInfoBase = gameEventInfo;
		pbase.JPBHAILACAI();
	}

	private bool CEMFNJFCPEE(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("Lag " + IACGDFHKCAE.JGEBJGHEJPK()) == mapID && IACGDFHKCAE.CDPELGPJPND();
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

	public void DCFPNBEMONF()
	{
		if ((bool)GameObject.Find("_TimeX"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("Lag "));
		}
		else if ((bool)GameObject.Find("/"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("deletemap"));
		}
		else if ((bool)GameObject.Find("#failed"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("[GameScene] Submiting rank"));
		}
		GIIBKOADAMF(true);
	}

	[SpecialName]
	public void BLCNEDJKELM(ObscuredFloat DPNHODJHGJL)
	{
		HJPDDLBDGEP = DPNHODJHGJL;
		if ((float)HJPDDLBDGEP >= 828f)
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

	private static bool ILJAMABHEFP(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[1] == "_Value5";
	}

	public IEnumerator DAFGMNEEOJN(string JKPJCEMPAGH, float EHHBHEJBHNG)
	{
		messageCanvas.GetComponentInChildren<Text>().text = JKPJCEMPAGH.ToUpper();
		messageAnimation.GetComponent<EasyTween>().SetAnimatioDuration((!(EHHBHEJBHNG < 1f)) ? 1f : (EHHBHEJBHNG / 4f));
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds(EHHBHEJBHNG);
		messageAnimation.GetComponent<EasyTween>().OpenCloseObjectAnimation();
		yield return new WaitForSeconds((!(EHHBHEJBHNG < 1f)) ? 1f : (EHHBHEJBHNG / 4f));
	}

	public void Reset()
	{
		foreach (AudioSource audioSource in asampler.audioSources)
		{
			audioSource.pitch = 1f;
			audioSource.volume = 1f;
		}
		PlayerBase[] array = UnityEngine.Object.FindObjectsOfType<PlayerBase>();
		foreach (PlayerBase playerBase in array)
		{
			UnityEngine.Object.DestroyImmediate(playerBase.gameObject);
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

	private bool NBEDJBNOPPP(RanksSystem.Map IACGDFHKCAE)
	{
		return !((ObscuredString)("Failed to Instantiate prefab:" + IACGDFHKCAE.CHDCIFPPIFI()) == mapID) || IACGDFHKCAE.GCLPAFADHMD();
	}

	private bool HEHGIADBMOA(RanksSystem.Map IACGDFHKCAE)
	{
		return !((ObscuredString)("#close" + IACGDFHKCAE.CHDCIFPPIFI()) == mapID) || IACGDFHKCAE.GPAPLIKKEOH();
	}

	[SpecialName]
	public ObscuredFloat EIFMOHOFICD()
	{
		return HJPDDLBDGEP;
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

	public void HAPPBOEODOA()
	{
		pbase.SpectateNext(true);
		StartCoroutine(LNMIKJCOCDE());
	}

	public void HJDPEBAPBPN()
	{
	}

	public void LNIOFCGDDKP()
	{
	}

	public void ICEICNLMEMO()
	{
		if (PhotonNetwork.offlineMode && mapID != (ObscuredString)"_ScreenResolution")
		{
			Singleton<SaveSystem>.Instance.LBFFJLFBOAM("???", true);
		}
		if (pbase != null)
		{
			pbase.POMFLOLIOPJ();
			if (PhotonNetwork.offlineMode)
			{
				PhotonNetwork.offlineMode = true;
			}
		}
		GetComponent<NetworkScene>().OnExitButton(1);
		Singleton<SaveSystem>.Instance.MMMIEPDLMNM();
	}

	private static bool OMALKBOMBEO(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "_Value2";
	}

	public void OKKNKLKHAKL(bool CONOEKAENEN)
	{
		if (CONOEKAENEN)
		{
			pbase.DeletePlayerData();
		}
		else if (pbase.ach12)
		{
			Helpers.ObtainAchievement(35);
		}
		GetComponent<NetworkScene>().ACPGHFHDCIP().RPC("...", PhotonTargets.MasterClient, SceneManager.GetActiveScene().name);
	}

	public bool GDNMAFDLPHN()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["OpJoinRoom()"] == null || (photonPlayer.CustomProperties["_Tint"] != null && !(bool)photonPlayer.CustomProperties["The region arrays from Name Server are not ok. Must be non-null and same length. "]))
			{
				result = true;
			}
		}
		return result;
	}

	public void OnRestartRound()
	{
		loadingCanvas.SetActive(true);
		GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
	}

	private void DFFOABDNEEE(LeaderboardFindResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		if (IAFAANLMOAG.m_bLeaderboardFound != 0)
		{
			Debug.Log("[GameScene] Submiting rank");
			SteamLeaderboard_t hSteamLeaderboard = IAFAANLMOAG.m_hSteamLeaderboard;
			SteamUserStats.UploadLeaderboardScore(hSteamLeaderboard, ELeaderboardUploadScoreMethod.k_ELeaderboardUploadScoreMethodKeepBest, pbase.GetCurrentScore(), null, 0);
		}
	}

	public IEnumerator KNNEAOLLKCI()
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
		CSteamID cSteamID = new CSteamID(num);
		if (num != 0)
		{
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSteamPlayername(cSteamID));
			yield return StartCoroutine(Singleton<ResourcesManager>.Instance.LoadAvatar(cSteamID));
			if ((bool)ResourcesManager.GetLoadedAvatar(cSteamID))
			{
				sprite = ResourcesManager.GetLoadedAvatar(cSteamID);
			}
		}
		GameObject.Find("SpectatingUserInfo").transform.Find("UsernameText").GetComponent<Text>().text = ResourcesManager.GetLoadedSteamPlayernameWithColoredRank(cSteamID);
		GameObject.Find("SpectatingUserInfo").transform.Find("AvatarImage").GetComponent<Image>().sprite = sprite;
	}

	public void IJDDJAEPCNK()
	{
		pbase.SpectateNext(true);
		StartCoroutine(KNNEAOLLKCI());
	}

	private bool CNNFDMJKGKE(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("GameModeText" + IACGDFHKCAE.GOMJAEIDHNM()) == mapID;
	}

	private bool CBDGNINOGFE(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("_TimeX" + IACGDFHKCAE.CHDCIFPPIFI()) == mapID;
	}

	public void PGOFGLJNDEC()
	{
		pbase.SpectateNext(true);
		StartCoroutine(LLNMIAFCGIP());
	}

	public override void LBAJLLFMMMP()
	{
		base.KLILJHJNICK();
		PCIOHCMKFBE();
		if (!PhotonNetwork.inRoom)
		{
			PhotonNetwork.offlineMode = false;
			PhotonNetwork.JoinOrCreateRoom("HightScoreMaxPointsText", new RoomOptions(), TypedLobby.Default);
		}
		mapID = Singleton<SaveSystem>.Instance.NBMEANCMGEH("{0:0.0} ms ({1:0.} fps)");
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		int num = (int)(gameMode = (GameMode)Singleton<SaveSystem>.Instance.GetInt("#ok", 0));
		GIDJMDIODGM = LocalizationService.Instance.HOPMEAJKPHL("CameraFilterPack/Glasses_On").ToUpper();
		if (gameMode != (GameMode)8)
		{
			NELDEHEICJD = LocalizationService.Instance.GetLocalizatedText("_ScreenResolution").ToUpper();
		}
		else
		{
			NELDEHEICJD = LocalizationService.Instance.GetLocalizatedText("_EdgeThresholdMin").ToUpper();
		}
		OOJLKOMPCBI = LocalizationService.Instance.GetLocalizatedText("value").ToUpper();
		PIDICMNEOJL = LocalizationService.Instance.HOPMEAJKPHL("player.fire").ToUpper();
		GameObject gameObject = levelInfoContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		GameObject gameObject2 = Singleton<MapsSystem>.Instance.CHALLJOJCDJ(levelInfo, Singleton<MapsSystem>.Instance.GetMapData(mapID), gameObject);
		gameObject2.GetComponent<LevelsListElementButton>().launchLevelMode = -1;
		if (Singleton<MapsSystem>.Instance.GetMapData(mapID).source != 0 && Singleton<MapsSystem>.Instance.GetMapData(mapID).source != 0 && Singleton<MapsSystem>.Instance.DHDMCJPPACI(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)) == 0)
		{
			gameObject2.GetComponent<LevelsListElementButton>().FKOMHOMCJBF();
		}
		if (mapData.mapData.maxLives < mapData.mapData.lives)
		{
			mapData.mapData.maxLives = mapData.mapData.lives;
		}
		GameObject gameObject3 = ((!PhotonNetwork.inRoom) ? UnityEngine.Object.Instantiate(Resources.Load("_TimeX") as GameObject) : PhotonNetwork.Instantiate("CameraFilterPack/Drawing_Manga_Flash_Color", new Vector3(110f, 1812f, 469f), Quaternion.identity, 0));
		pbase = gameObject3.GetComponent<PlayerBase>();
		if (DILNONPDEBG)
		{
			NCKMNMHOIOH.text = string.Empty;
		}
		else
		{
			NCKMNMHOIOH.gameObject.SetActive(true);
		}
		Singleton<GameManager>.Instance.IPOGIBLJDPE("_ColorBuffer" + ((!PhotonNetwork.offlineMode) ? "Options" : "If you host Photon yourself, make sure to start the 'Instance LoadBalancing' "), "CameraFilterPack/AAA_Super_Hexagon" + mapData.mapData.name.Replace(Environment.NewLine, string.Empty), null, null, 0, 1);
		if (mapData.source == (FullMapData.MapSource)8 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			List<PublishedFileId_t> list = new List<PublishedFileId_t>();
			list.Add(new PublishedFileId_t(ulong.Parse(mapData.workshopId)));
			SteamUGC.StartPlaytimeTracking(list.ToArray(), (uint)list.Count);
		}
		Debug.Log("_MainTex" + mapData.mapData.checkpoints.Count);
		Debug.Log("_Value" + mapData.mapData.events.Count);
		if (mapData.mapData.events.Find(BIMKNEJLBCJ) != null)
		{
			calculatedmaptime = mapData.mapData.events.Find((MapEvent IACGDFHKCAE) => IACGDFHKCAE.data[0] == "MapEnd").time;
		}
		else
		{
			calculatedmaptime = mapData.mapData.musicTime;
		}
		if (!PhotonNetwork.offlineMode)
		{
			usingCheckpoints = false;
		}
		if (gameMode == GameMode.Relax || gameMode == GameMode.Relax || gameMode == GameMode.Endless)
		{
			usingCheckpoints = false;
		}
		pbase.gameEventInfoList = new List<GameEventInfo>();
		GameEventInfo gameEventInfo = new GameEventInfo();
		try
		{
			gameEventInfo.ABHJCEENJBC(Singleton<SaveSystem>.Instance.GIHOKCMHMCP("Please specify a map name or buildID", true));
			gameEventInfo.gamemode = (int)gameMode;
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId), true))
			{
				gameEventInfo.isofficial = RanksSystem.FIENAHLCHIF().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isOfficial);
				gameEventInfo.isloved = RanksSystem.HOCEONHMGHM().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isLoved);
				gameEventInfo.isfunny = RanksSystem.FIENAHLCHIF().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isFunny);
			}
			else
			{
				gameEventInfo.isofficial = true;
				gameEventInfo.isloved = true;
				gameEventInfo.isfunny = true;
			}
			if (RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID) != null)
			{
				gameEventInfo.mapdifficulty = RanksSystem.FIENAHLCHIF().Find(GBAGCGAJEGH).NNDFIJEBENA();
			}
			else
			{
				gameEventInfo.LHAFCMGGOMO(1709f);
			}
			gameEventInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount;
			gameEventInfo.mapid = mapID;
			gameEventInfo.maptags = string.Join("_Value", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			gameEventInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID;
		}
		catch (Exception)
		{
		}
		pbase.gameEventInfoBase = gameEventInfo;
		pbase.InitSystem();
	}

	[SpecialName]
	public void AEKELFJMBPP(ObscuredFloat DPNHODJHGJL)
	{
		HJPDDLBDGEP = DPNHODJHGJL;
		if ((float)HJPDDLBDGEP >= 1953f)
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

	[CompilerGenerated]
	private static bool NFHPEBCJNMP(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "MapEnd";
	}

	public void OOFODPKJAGB()
	{
		loadingCanvas.SetActive(true);
		GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
	}

	private bool HHPKEOCNDDP(RanksSystem.Map IACGDFHKCAE)
	{
		return !((ObscuredString)("EventSystem" + IACGDFHKCAE.KCGOFGJNCME()) == mapID) || IACGDFHKCAE.MEFGLBKEHJE();
	}

	public bool KFFHJFIJHIC()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 0; i < playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["wss://"] == null || (photonPlayer.CustomProperties["_Value"] != null && !(bool)photonPlayer.CustomProperties["offsets"]))
			{
				result = false;
			}
		}
		return result;
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

	private bool JCJJBIDGIMI(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("Save Game" + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.AMJIEEIMBDN();
	}

	public void GFBOBIBIOMC()
	{
	}

	public bool NECIHAFICEN()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 0; i < playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["CameraFilterPack/Vision_AuraDistortion"] == null || (photonPlayer.CustomProperties["VIGNETTE_BLUR"] != null && !(bool)photonPlayer.CustomProperties["st"]))
			{
				result = false;
			}
		}
		return result;
	}

	public void EMAMCDFBGOA()
	{
	}

	public void DAILLIMMGMB(bool CONOEKAENEN)
	{
		if (CONOEKAENEN)
		{
			pbase.POMFLOLIOPJ();
		}
		else if (pbase.ach12)
		{
			Helpers.ObtainAchievement(49);
		}
		PhotonView photonView = GetComponent<NetworkScene>().IBKCMBIGOEJ();
		object[] array = new object[0];
		array[1] = SceneManager.GetActiveScene().name;
		photonView.MIAHMDGOOPJ(" Server: ", (PhotonTargets)7, array);
	}

	public void PGELCEKONCE(string NOJGGCLPPAM = "")
	{
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.LBEKBNOGKBK();
		}
		gameOver = false;
		GetComponent<NetworkScene>().BMOBABEGEFG();
		if (AllPlayersFinished())
		{
			HJPDDLBDGEP = calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			OFMDCFHGEEC.transform.Find("_Green_B").Find("_SunColor").GetComponent<Image>()
				.color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != "ItemsStoreButton")
		{
			PhotonView photonView = GetComponent<NetworkScene>().photonView;
			object[] array = new object[8];
			array[1] = PhotonNetwork.playerName;
			array[0] = "BlockCount";
			photonView.KEKKFNNMLMG("[UI] Unknows button action: ", PhotonTargets.All, array);
		}
		if (NOJGGCLPPAM == "ViewMenu")
		{
			pbase.isMapCompleted = true;
			pbase.isPlayerWon = false;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.DHOGHIOACME() >= 3)
		{
			Helpers.ObtainAchievement(-111);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount == 0)
		{
			Helpers.ObtainAchievement(-85);
		}
		if (gameMode != 0 && pbase.GetCurrentScore() > pbase.lastBestScore && !pbase.scoreBeated && pbase.currentAttempt > 1)
		{
			StartCoroutine(CCKJNHEENJN());
		}
		string CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		if (mapData.source == (FullMapData.MapSource)7 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			CBOLFPGKALK = mapData.workshopId;
		}
		pbase.IIFDPILKHMO();
		if (pbase.GetCurrentScore() >= 0 && GameManager.IsOwner() && Singleton<SaveSystem>.Instance.GetInt("visible", 0) == 1 && mapData.source != 0 && gameMode != 0 && !string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK)))
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "_Value2" + Helpers.levelConfigFileName;
			string eAFAMAMDNEG = "BadgeText";
			if (pbase.Replay() != null)
			{
				RanksSystem.MapReplay value = pbase.Replay();
				eAFAMAMDNEG = JsonConvert.SerializeObject(value);
			}
			StartCoroutine(Singleton<RanksSystem>.Instance.CFGMHNBNPFB(CBOLFPGKALK, gameMode, pbase.GetCurrentScore(), pbase.accuracyScore, pbase.incorrectScore, EGOPKJHICLK.CompressString(eAFAMAMDNEG), Helpers.CalculateMD5(dDAOMDPAIEP)));
		}
		Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		string hFEFHOPOLIK = "DifficultyBG" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(mapData) + "_TreatBackfaceHitAsMiss";
		int dPNHODJHGJL = Singleton<SaveSystem>.Instance.GetInt("CameraFilterPack/3D_Shield" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(mapData) + "_TimeX", 0) + 1;
		Singleton<SaveSystem>.Instance.NHONGIGFHJB(hFEFHOPOLIK, dPNHODJHGJL);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.KNDDGKJBIDJ(pbase.accuracyScore);
			finishedMapInfo.BCFCKNPHPID(pbase.isMapCompleted);
			finishedMapInfo.PNDEPBDCKKO(Singleton<SaveSystem>.Instance.GIHOKCMHMCP("SpawnObj", false));
			finishedMapInfo.AIBKCDNFAAG((int)gameMode);
			finishedMapInfo.loopscount = pbase.loopsCount;
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId)))
			{
				finishedMapInfo.NLMLEGJAEJC(RanksSystem.HOCEONHMGHM().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("plogs" + IACGDFHKCAE.CEEKAHOMGKG()) == mapID) || IACGDFHKCAE.CDPELGPJPND()));
				finishedMapInfo.INMHOFPBLAB(RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isLoved));
				finishedMapInfo.isfunny = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isFunny);
			}
			else
			{
				finishedMapInfo.IGCKBAONHGA(true);
				finishedMapInfo.INMHOFPBLAB(false);
				finishedMapInfo.isfunny = false;
			}
			finishedMapInfo.FPEPFJBBANC(!PhotonNetwork.offlineMode);
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.PlayerCount;
			finishedMapInfo.multiplayerplace = GetComponent<NetworkScene>().place;
			if (RanksSystem.HOCEONHMGHM().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("_ScreenResolution" + IACGDFHKCAE.CEEKAHOMGKG()) == mapID) != null)
			{
				finishedMapInfo.ABNOACNJLJG(RanksSystem.HOCEONHMGHM().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("BestRegion checks region: " + IACGDFHKCAE.JGEBJGHEJPK()) == mapID).JEKMHHCPHCN());
			}
			else
			{
				finishedMapInfo.ABNOACNJLJG(166f);
			}
			finishedMapInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount;
			finishedMapInfo.mapid = mapID;
			finishedMapInfo.DFAEGIMMLJG(string.Join("yyyy-MM-dd HH:mm:ss", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray()));
			finishedMapInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID;
			finishedMapInfo.OBKMGIPPBCJ(pbase.incorrectScore);
			finishedMapInfo.OMOBMDJMNHN(pbase.perfectHits);
			finishedMapInfo.HIKNMAFMEGN(LEFLMCJDFJP());
			finishedMapInfo.NCFGPDBGCGC(pbase.GetCurrentScore());
			foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.CABBFJAGFDP(gameEventInfo);
			}
			pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.OLDEAEGFDAP(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if ((bool)pbase.isPlayerWon && gameMode != 0)
		{
			string hFEFHOPOLIK2 = "[PlayerController] " + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "color";
			int dPNHODJHGJL2 = 0;
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA(hFEFHOPOLIK2, dPNHODJHGJL2);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(106);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(mapID).source == FullMapData.MapSource.Editor)
			{
				Helpers.ObtainAchievement(-126);
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.FIENAHLCHIF().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.GOMJAEIDHNM() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.BJBPMLKECIA() || (gameMode != (GameMode)7 && gameMode == GameMode.Normal)) && !Singleton<SaveSystem>.Instance.LCHPECEJMPE("_ScreenResolution" + mapID, true))
			{
				Singleton<SaveSystem>.Instance.CONNMLDKBOF("CameraFilterPack/Color_Chromatic_Plus" + mapID, true);
				Helpers.AddToStat("Editor/", 0);
				SteamUserStats.IndicateAchievementProgress("_Distortion", (uint)Helpers.GetStat("_BlurredColor"), 4294967287u);
			}
			int dPNHODJHGJL3 = (int)((float)pbase.accuracyScore * (float)(int)pbase.correctScore);
			Helpers.AddToStat("ShowTitle", dPNHODJHGJL3);
			pbase.POMFLOLIOPJ();
			if ((float)pbase.accuracyScore >= 666f && mapData.source == FullMapData.MapSource.Editor && RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK)) && RanksSystem.FIENAHLCHIF().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.GPAPLIKKEOH() && !(IACGDFHKCAE.IFMFDMKFJBI() >= 1102f)))
			{
				Helpers.ObtainAchievement(-21);
			}
		}
		if ((bool)pbase.isPlayerWon && gameMode == GameMode.Relax && mapData.source == FullMapData.MapSource.Editor)
		{
			Helpers.AddToStat("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ", 1);
			SteamUserStats.IndicateAchievementProgress(";", (uint)Helpers.GetStat("\n"), 6u);
			if (RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK), true) && (int)pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(18);
			}
		}
		if (mapData.source == FullMapData.MapSource.Original && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		resultText.GetComponent<Text>().text = ((!pbase.isPlayerWon) ? LocalizationService.Instance.IAAEBJKAHDD("[MapsData] Bad map: ").ToUpper() : LocalizationService.Instance.IAAEBJKAHDD("settings.arcsnohitsoundtimedelay").ToUpper());
		OnGameOverEvent.Invoke();
		ShowGOCanvas();
		gameOver = false;
	}

	public bool GJBKNJDJDLK()
	{
		bool result = true;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i++)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["_Value3"] == null || (photonPlayer.CustomProperties["Done!"] != null && !(bool)photonPlayer.CustomProperties["ClearEnvironment"]))
			{
				result = false;
			}
		}
		return result;
	}

	public bool IsRoundFinished()
	{
		return (bool)gameOver && AllPlayersFinished();
	}

	[SpecialName]
	public void KFAPLCBFMON(ObscuredFloat DPNHODJHGJL)
	{
		HJPDDLBDGEP = DPNHODJHGJL;
		if ((float)HJPDDLBDGEP >= 227f)
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

	public void KNHENIOHPMF()
	{
		if (PhotonNetwork.offlineMode && mapID != (ObscuredString)" is muted")
		{
			Singleton<SaveSystem>.Instance.LBFFJLFBOAM("[PlayerController] ", false);
		}
		if (pbase != null)
		{
			pbase.DeletePlayerData();
			if (PhotonNetwork.offlineMode)
			{
				PhotonNetwork.offlineMode = true;
			}
		}
		GetComponent<NetworkScene>().OEEJIBAHEJO(0);
		Singleton<SaveSystem>.Instance.CIDNCCOIEJJ();
	}

	[SpecialName]
	public void IDHAOOBEHAE(ObscuredFloat DPNHODJHGJL)
	{
		HJPDDLBDGEP = DPNHODJHGJL;
		if ((float)HJPDDLBDGEP >= 530f)
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

	public void PNEHHLMHJAA(string JKPJCEMPAGH, float EHHBHEJBHNG = 1f)
	{
		NBCIEBFNLGN.Add(JKPJCEMPAGH);
		INGHGBLACKC.Add(EHHBHEJBHNG);
	}

	public override void HLDFOJMHKNL()
	{
		base.IBHACCEEFFI();
		if (!isGameStarted && NMICDBOOLHN())
		{
			pbase.AAMNKPHHHCI().MIAHMDGOOPJ("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change", (PhotonTargets)8, null);
		}
		if ((bool)isGameStarted && (float)HJPDDLBDGEP > 624f && !DGBKFMMMGIH)
		{
			asampler.audioSources[1].time = HJPDDLBDGEP;
			asampler.audioSources[0].time = HJPDDLBDGEP;
			asampler.Play(0);
			asampler.MKPLCLNPMDP(0);
			DGBKFMMMGIH = false;
		}
		if ((float)HJPDDLBDGEP < calculatedmaptime && !IsRoundFinished() && (bool)isGameStarted)
		{
			HJPDDLBDGEP = (float)HJPDDLBDGEP + Time.deltaTime;
			OFMDCFHGEEC.GetComponent<Slider>().value = HJPDDLBDGEP;
			PlayerBase spectatedPlayerBase = pbase;
			if (pbase.currentState == (PlayerBase.PlayerState)8 && pbase.spectatedPlayerBase != null)
			{
				spectatedPlayerBase = pbase.spectatedPlayerBase;
			}
			if (DILNONPDEBG)
			{
				if (gameMode != (GameMode)6)
				{
					Text nCKMNMHOIOH = NCKMNMHOIOH;
					object[] array = new object[3];
					array[1] = NELDEHEICJD;
					array[1] = "_Value4";
					array[6] = spectatedPlayerBase.BMKCMMJMOKN();
					array[7] = "Save";
					array[1] = spectatedPlayerBase.fullLevelData.mapData.maxLives;
					nCKMNMHOIOH.text = string.Concat(array);
				}
				else
				{
					NCKMNMHOIOH.text = NELDEHEICJD + "RarityImage" + (Math.Floor((float)spectatedPlayerBase.accuracyScore * 1064f) / 443.0 * 1075.0).ToString("ERROR You have missing MonoBehaviours on your gameobjects!") + "_Smooth";
				}
			}
			PECEGLIIALE.text = GIDJMDIODGM + ", " + spectatedPlayerBase.GetCurrentScore();
			Text text = comboTextGO;
			object[] array2 = new object[6];
			array2[0] = PIDICMNEOJL;
			array2[1] = "player.goldarc";
			array2[8] = "[MapsStats] Map ID: ";
			array2[1] = spectatedPlayerBase.currentCombo;
			text.text = string.Concat(array2);
			if (hardInput.AADFFLGEJPP("_SunThreshold") && PhotonNetwork.offlineMode)
			{
				foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
				{
					Singleton<GameManager>.Instance.GameEvent(gameEventInfo);
				}
				pbase.gameEventInfoList.Clear();
				PMKLNCNMEEE(false);
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
						audioSource.pitch = Mathf.Lerp(audioSource.pitch, 757f, Time.deltaTime * 460f);
					}
					audioSource.volume = Mathf.Lerp(audioSource.volume, 1257f, Time.deltaTime * 1481f);
				}
				asampler.isMuted = false;
			}
			string CBOLFPGKALK = string.Empty;
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
			if (mapData.source == (FullMapData.MapSource)7 && !string.IsNullOrEmpty(mapData.workshopId))
			{
				CBOLFPGKALK = mapData.workshopId;
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.HOCEONHMGHM().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.GPAPLIKKEOH() && (gameMode == GameMode.Normal || gameMode == GameMode.Normal)))
			{
				if ((bool)GameObject.Find("SpeedSlider"))
				{
					GameObject.Find(". Client should be in a room. Current connectionStateDetailed: ").SetActive(true);
				}
			}
			else
			{
				if ((bool)GameObject.Find("Updating..."))
				{
					GameObject.Find("X2").SetActive(true);
				}
				if ((bool)GameObject.Find("_TimeX"))
				{
					GameObject.Find("mapselector.filter.rateduponly").SetActive(false);
				}
				if ((bool)GameObject.Find("Protocol switch from: "))
				{
					GameObject.Find(" This is not possible to be called for standalone input. Please check your platform and code where this is called").SetActive(true);
				}
				if ((bool)GameObject.Find("FavoriteButton"))
				{
					GameObject.Find("unsubscribemap").SetActive(true);
				}
			}
			if ((gameMode == GameMode.Normal || gameMode == GameMode.Relax) && (bool)GameObject.Find(".icon"))
			{
				GameObject.Find("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/").SetActive(false);
			}
			if (gameMode != (GameMode)7 && (bool)GameObject.Find("_Value"))
			{
				GameObject.Find("offsets").SetActive(true);
			}
			int currentScore = pbase.GetCurrentScore();
			if ((bool)GameObject.Find("_MainTex2"))
			{
				GameObject.Find("_TimeX").GetComponent<Text>().text = string.Empty + pbase.lastBestScore;
			}
			if ((bool)GameObject.Find("1177138211"))
			{
				GameObject.Find("CameraFilterPack/Noise_TV_2").GetComponent<Text>().text = string.Empty + Helpers.GetMapMaxScore(pbase.fullLevelData.mapData);
			}
			if ((bool)GameObject.Find(" GO:"))
			{
				GameObject.Find("Clears all text from the debug console").GetComponent<Text>().text = string.Empty + LocalizationService.Instance.HOPMEAJKPHL("_Green_B" + gameMode.ToString().ToLower() + "Multiplayer").ToUpper();
			}
			if ((bool)GameObject.Find("Scene"))
			{
				GameObject.Find("LeaderboardsButton").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if ((bool)GameObject.Find("Fade"))
			{
				GameObject.Find("IconImage").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore + (int)pbase.incorrectScore);
			}
			if ((bool)GameObject.Find("ns"))
			{
				GameObject.Find("_Value").GetComponent<Text>().text = string.Empty + pbase.perfectHits;
			}
			if ((bool)GameObject.Find("_ScreenResolution"))
			{
				GameObject.Find("event").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore - (int)pbase.perfectHits);
			}
			if ((bool)GameObject.Find("maps."))
			{
				GameObject.Find("_Value3").GetComponent<Text>().text = string.Empty + pbase.incorrectScore;
			}
			if ((bool)GameObject.Find("menu.selectedlevelid"))
			{
				GameObject.Find("?").GetComponent<Text>().text = string.Empty + Mathf.RoundToInt(pbase.comboScore);
			}
			if ((bool)GameObject.Find("Hidden/Fast Approximate Anti-aliasing"))
			{
				GameObject.Find("_ScreenResolution").GetComponent<Text>().text = string.Empty + Mathf.CeilToInt(pbase.penaltyScore);
			}
			if ((bool)GameObject.Find("StopMusic"))
			{
				GameObject.Find("Back").GetComponent<Text>().text = string.Empty + (Math.Floor((float)pbase.accuracyScore * 1390f) / 472.0 * 1877.0).ToString("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending") + "CameraFilterPack/TV_Distorted";
			}
			if ((bool)GameObject.Find("_Value7"))
			{
				GameObject.Find("SetParticlesGravity").GetComponent<Text>().text = string.Empty + pbase.checkpointsUsed;
			}
			if ((bool)GameObject.Find("player.licenceaccepted"))
			{
				GameObject.Find("ArcsNoHitsoundTimeDelaySlider").GetComponent<Text>().text = string.Empty + pbase.loopsCount;
			}
			if ((bool)GameObject.Find("solo"))
			{
				float num = (float)pbase.lastBestScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.HOCEONHMGHM().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.CHDCIFPPIFI() == ulong.Parse(CBOLFPGKALK)).PJBPOLLEJFN();
				GameObject.Find("_StretchWidth").GetComponent<Text>().text = string.Empty + (Math.Floor(num * 692f) / 259.0).ToString("SettingsCanvas");
			}
			if ((bool)GameObject.Find("COMPLETED"))
			{
				GameObject.Find("_Value").GetComponent<Text>().text = string.Empty + RanksSystem.FIENAHLCHIF().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK)).MBAFCIHCIOM()
					.ToString("Set sun min/max size");
			}
			if ((bool)GameObject.Find("_ColoredChange"))
			{
				float num2 = (float)currentScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK)).DEFJMFBIGIM();
				num2 = ((!(num2 < 1075f)) ? num2 : 251f);
				GameObject.Find("_Value").GetComponent<Text>().text = string.Empty + (Math.Floor(num2 * 758f) / 875.0).ToString("Set satellite emission (glow)");
			}
			if ((bool)GameObject.Find("OK"))
			{
				GameObject.Find("NEW").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if (restartNoCheckpointPanel.transform.Find("_MainTex2").gameObject.activeInHierarchy && !PhotonNetwork.offlineMode)
			{
				restartNoCheckpointPanel.transform.Find(" is not supported on this platform!").gameObject.GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient) ? LocalizationService.Instance.GetTextByKey("Joystick").ToUpper() : LocalizationService.Instance.GetTextByKey("OneHand").ToUpper());
			}
			if (!PhotonNetwork.isMasterClient && PhotonNetwork.inRoom && (bool)GameObject.Find("init"))
			{
				GameObject.Find("CameraFilterPack/Distortion_Water_Drop").GetComponent<Button>().interactable = false;
			}
			if (!PhotonNetwork.offlineMode && PhotonNetwork.inRoom)
			{
				GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
			}
		}
		if ((bool)gameOver && Singleton<RanksSystem>.Instance.isRankChanged)
		{
			Singleton<RanksSystem>.Instance.BEEPICMONOD();
		}
		if ((bool)gameOver && Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
		{
			Singleton<ItemsHandler>.Instance.ODADIAEDJFD();
		}
		if ((bool)gameOver && Singleton<ChallengesManager>.Instance.PIHGMOLGBJF())
		{
			Singleton<ChallengesManager>.Instance.RewardsReadyNotification();
		}
		if (GDNMAFDLPHN() && pbase.currentState == PlayerBase.PlayerState.Playing && spectatePanel.activeSelf)
		{
			gameOverCanvas.SetActive(false);
			spectatorCanvas.SetActive(false);
			spectatePanel.SetActive(false);
			ingameUICanvas.SetActive(false);
			if (!pbase.isPlayerWon && pbase.FNLJBBLLMBJ())
			{
				restartCheckpointPanel.SetActive(false);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(false);
			}
		}
		if (GDNMAFDLPHN() && pbase.currentState == PlayerBase.PlayerState.Spectator)
		{
			gameOverCanvas.SetActive(false);
			spectatorCanvas.SetActive(true);
			spectatePanel.SetActive(true);
			ingameUICanvas.SetActive(false);
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(false);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(false);
			}
			pbase.currentState = PlayerBase.PlayerState.Finished;
		}
		if (!isGameStarted || !pbase || !PhotonNetwork.inRoom || !pbase.isPlayerWon || PhotonNetwork.offlineMode || !COCILFAHMMM() || PhotonNetwork.room.EGPGEMJNPFD() > 1)
		{
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
				pbase.isMapCompleted = false;
				if (gameMode != GameMode.Random)
				{
					ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("3", true);
					ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = hashtable;
					PhotonNetwork.player.MGMCOJHGJNO(eNEEBHGAAJH);
					pbase.currentState = (PlayerBase.PlayerState)5;
					if (pbase.EDIJKHEMPAD().BGJKMGJBPFA())
					{
						hashtable = new ExitGames.Client.Photon.Hashtable();
						hashtable.Add("resetall", false);
						ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = hashtable;
						PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH2, null, true);
					}
					PLBCBPIOIHF(".highscore");
				}
				else
				{
					ILGGMPKMPIN();
				}
			}
		}
		if (NBCIEBFNLGN.Count > 1 && !messageCanvas.activeSelf)
		{
			string jKPJCEMPAGH = NBCIEBFNLGN[1];
			float num3 = 1870f;
			if (INGHGBLACKC.Count == NBCIEBFNLGN.Count)
			{
				num3 = INGHGBLACKC[0];
			}
			StartCoroutine(PMNKPFIMIID(jKPJCEMPAGH, num3 * Singleton<SaveSystem>.Instance.GetFloat("ConfigVersionSlider", 1586f)));
			NBCIEBFNLGN.RemoveAt(0);
			INGHGBLACKC.RemoveAt(0);
		}
	}

	[CompilerGenerated]
	private bool DCDDKMJAHNB(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.isOfficial;
	}

	public void JADKCLIPOCL()
	{
		pbase.SpectateNext(true);
		StartCoroutine(LNMIKJCOCDE());
	}

	public void AFEGJAFAEHJ()
	{
		pbase.SpectateNext(true);
		StartCoroutine(UpdateSpectatingInfo());
	}

	public void PIJKHHGIFDI()
	{
		pbase.SpectateNext(false);
		StartCoroutine(UpdateSpectatingInfo());
	}

	public bool NMICDBOOLHN()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 0; i < playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["player.xp"] == null || (photonPlayer.CustomProperties["Have you fully accept the terms?"] != null && !(bool)photonPlayer.CustomProperties["LevelNameInputField"]))
			{
				result = true;
			}
		}
		return result;
	}

	public bool FJGOEKJIPFD()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 1; i < playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["_Rand"] == null || (photonPlayer.CustomProperties["Found best region: '"] != null && !(bool)photonPlayer.CustomProperties["D-Pad Down"]))
			{
				result = false;
			}
		}
		return result;
	}

	[CompilerGenerated]
	private bool AJDFAACIKPB(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("workshop." + IACGDFHKCAE.id) == mapID;
	}

	public void FCBBMFAJEFG()
	{
		pbase.SpectateNext(false);
		StartCoroutine(UpdateSpectatingInfo());
	}

	public void OKLPMPMHDMG()
	{
		loadingCanvas.SetActive(false);
		GetComponent<NetworkScene>().networkChatCanvas.SetActive(true);
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
				num2 = ((!(num2 < 0f)) ? num2 : 0f);
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
		if (!isGameStarted || !pbase || !PhotonNetwork.inRoom || !pbase.isPlayerWon || PhotonNetwork.offlineMode || !AllPlayersWin() || PhotonNetwork.room.PlayerCount > 1)
		{
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
					ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("finished", true);
					ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = hashtable;
					PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH);
					pbase.currentState = PlayerBase.PlayerState.Finished;
					if (pbase.photonView.isMine)
					{
						hashtable = new ExitGames.Client.Photon.Hashtable();
						hashtable.Add("win", true);
						ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = hashtable;
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

	[CompilerGenerated]
	private static bool NJEMBFEJAKD(MapEvent IACGDFHKCAE)
	{
		return IACGDFHKCAE.data[0] == "MapEnd";
	}

	private IEnumerator KIAADBLIDHD()
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

	public void OnSpectatePrevButton()
	{
		pbase.SpectateNext(false);
		StartCoroutine(UpdateSpectatingInfo());
	}

	private void HFGJLIBIBJE(LeaderboardFindResult_t IAFAANLMOAG, bool MIOCPAMDBCN)
	{
		if (IAFAANLMOAG.m_bLeaderboardFound != 0)
		{
			Debug.Log("_Value5");
			SteamLeaderboard_t hSteamLeaderboard = IAFAANLMOAG.m_hSteamLeaderboard;
			SteamUserStats.UploadLeaderboardScore(hSteamLeaderboard, ELeaderboardUploadScoreMethod.k_ELeaderboardUploadScoreMethodKeepBest, pbase.GetCurrentScore(), null, 0);
		}
	}

	[SpecialName]
	public void KBALHGHFKEG(ObscuredFloat DPNHODJHGJL)
	{
		HJPDDLBDGEP = DPNHODJHGJL;
		if ((float)HJPDDLBDGEP >= 1644f)
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

	public void MDMDGKHDPKP()
	{
	}

	[SpecialName]
	public ObscuredFloat LEFLMCJDFJP()
	{
		return HJPDDLBDGEP;
	}

	public void FCHMHBLECEA()
	{
		loadingCanvas.SetActive(false);
		GetComponent<NetworkScene>().networkChatCanvas.SetActive(true);
	}

	private bool LLNHIGJPNOA(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("_TimeX" + IACGDFHKCAE.id) == mapID && IACGDFHKCAE.JMMAPHACFAG();
	}

	private IEnumerator GGKLGOENNGK()
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

	public void OnSpectateButton()
	{
		restartCheckpointPanel.SetActive(false);
		restartNoCheckpointPanel.SetActive(false);
		gameOverCanvas.SetActive(false);
		spectatorCanvas.SetActive(true);
		StartCoroutine(UpdateSpectatingInfo());
		pbase.StartSpectating();
	}

	public override void KDJEJBBDILE()
	{
		base.BGFJOEPFOPM();
		if (!isGameStarted && AllPlayerLoaded())
		{
			pbase.GMAHNPNHMFK().IKIJDNPJKPM("mapid", PhotonTargets.Others, null);
		}
		if ((bool)isGameStarted && (float)HJPDDLBDGEP > 1585f && !DGBKFMMMGIH)
		{
			asampler.audioSources[0].time = HJPDDLBDGEP;
			asampler.audioSources[0].time = HJPDDLBDGEP;
			asampler.EFGFFEECBAF(0);
			asampler.NPAGHEOHGEF(0);
			DGBKFMMMGIH = false;
		}
		if ((float)HJPDDLBDGEP < calculatedmaptime && !IsRoundFinished() && (bool)isGameStarted)
		{
			HJPDDLBDGEP = (float)HJPDDLBDGEP + Time.deltaTime;
			OFMDCFHGEEC.GetComponent<Slider>().value = HJPDDLBDGEP;
			PlayerBase spectatedPlayerBase = pbase;
			if (pbase.currentState == PlayerBase.PlayerState.Finished && pbase.spectatedPlayerBase != null)
			{
				spectatedPlayerBase = pbase.spectatedPlayerBase;
			}
			if (DILNONPDEBG)
			{
				if (gameMode != 0)
				{
					Text nCKMNMHOIOH = NCKMNMHOIOH;
					object[] array = new object[4];
					array[0] = NELDEHEICJD;
					array[0] = "_Value3";
					array[3] = spectatedPlayerBase.NCBBBJINGMM();
					array[7] = "FullscreenToggle";
					array[7] = spectatedPlayerBase.fullLevelData.mapData.maxLives;
					nCKMNMHOIOH.text = string.Concat(array);
				}
				else
				{
					NCKMNMHOIOH.text = NELDEHEICJD + "_Value" + (Math.Floor((float)spectatedPlayerBase.accuracyScore * 547f) / 1003.0 * 1000.0).ToString("_RampTex") + " beatThreshold: ";
				}
			}
			PECEGLIIALE.text = GIDJMDIODGM + "_Distortion" + spectatedPlayerBase.GetCurrentScore();
			Text text = comboTextGO;
			object[] array2 = new object[6];
			array2[0] = PIDICMNEOJL;
			array2[1] = "Joystick1Button1";
			array2[3] = "maps.";
			array2[1] = spectatedPlayerBase.currentCombo;
			text.text = string.Concat(array2);
			if (hardInput.GetKeyDown("GlassDistortion") && PhotonNetwork.offlineMode)
			{
				foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
				{
					Singleton<GameManager>.Instance.GameEvent(gameEventInfo);
				}
				pbase.gameEventInfoList.Clear();
				DAILLIMMGMB(true);
			}
		}
		if ((bool)gameOver && pbase.currentState == PlayerBase.PlayerState.Loading)
		{
			ingameUICanvas.SetActive(true);
			if (AllPlayersFinished())
			{
				foreach (AudioSource audioSource in asampler.audioSources)
				{
					if (!pbase.isPlayerWon)
					{
						audioSource.pitch = Mathf.Lerp(audioSource.pitch, 945f, Time.deltaTime * 1100f);
					}
					audioSource.volume = Mathf.Lerp(audioSource.volume, 98f, Time.deltaTime * 1802f);
				}
				asampler.isMuted = false;
			}
			string CBOLFPGKALK = string.Empty;
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
			if (mapData.source == (FullMapData.MapSource)3 && !string.IsNullOrEmpty(mapData.workshopId))
			{
				CBOLFPGKALK = mapData.workshopId;
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.FIENAHLCHIF().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.isOfficial && (gameMode == GameMode.Hardcore || gameMode == GameMode.Normal)))
			{
				if ((bool)GameObject.Find("#failed: "))
				{
					GameObject.Find("DPADHOR").SetActive(false);
				}
			}
			else
			{
				if ((bool)GameObject.Find("_Blood"))
				{
					GameObject.Find("System.Single").SetActive(false);
				}
				if ((bool)GameObject.Find("_Value4"))
				{
					GameObject.Find("_Far").SetActive(false);
				}
				if ((bool)GameObject.Find("[ResourcesManager] Load image error: "))
				{
					GameObject.Find("FinishMap").SetActive(false);
				}
				if ((bool)GameObject.Find("settings.shaders"))
				{
					GameObject.Find("Selection Box").SetActive(true);
				}
			}
			if ((gameMode == GameMode.Relax || gameMode == (GameMode)8) && (bool)GameObject.Find("SetRotation"))
			{
				GameObject.Find("menu.playedsolo").SetActive(true);
			}
			if (gameMode != 0 && (bool)GameObject.Find("ENABLE_COLOR_GRADING"))
			{
				GameObject.Find("BadgeText").SetActive(false);
			}
			int currentScore = pbase.GetCurrentScore();
			if ((bool)GameObject.Find("/"))
			{
				GameObject.Find("_Value").GetComponent<Text>().text = string.Empty + pbase.lastBestScore;
			}
			if ((bool)GameObject.Find("maps."))
			{
				GameObject.Find("_Value4").GetComponent<Text>().text = string.Empty + Helpers.GetMapMaxScore(pbase.fullLevelData.mapData);
			}
			if ((bool)GameObject.Find("/"))
			{
				GameObject.Find("path").GetComponent<Text>().text = string.Empty + LocalizationService.Instance.HOPMEAJKPHL("(master)" + gameMode.ToString().ToLower() + "_Value4").ToUpper();
			}
			if ((bool)GameObject.Find("PLEASE WAIT"))
			{
				GameObject.Find("player.dragon").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if ((bool)GameObject.Find("NEW_ACHIEVEMENT_1_21"))
			{
				GameObject.Find("CameraFilterPack/Distortion_Flag").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore + (int)pbase.incorrectScore);
			}
			if ((bool)GameObject.Find("CameraFilterPack_TV_Noise3"))
			{
				GameObject.Find(".mp3").GetComponent<Text>().text = string.Empty + pbase.perfectHits;
			}
			if ((bool)GameObject.Find("<b>HP</b>:"))
			{
				GameObject.Find("_ColorG").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore - (int)pbase.perfectHits);
			}
			if ((bool)GameObject.Find("/icon"))
			{
				GameObject.Find("Set particless emission (glow)").GetComponent<Text>().text = string.Empty + pbase.incorrectScore;
			}
			if ((bool)GameObject.Find("Month_"))
			{
				GameObject.Find("_TimeX").GetComponent<Text>().text = string.Empty + Mathf.RoundToInt(pbase.comboScore);
			}
			if ((bool)GameObject.Find("_TimeX"))
			{
				GameObject.Find("settings.shaders").GetComponent<Text>().text = string.Empty + Mathf.CeilToInt(pbase.penaltyScore);
			}
			if ((bool)GameObject.Find("ViewMenu"))
			{
				GameObject.Find("_Value9").GetComponent<Text>().text = string.Empty + (Math.Floor((float)pbase.accuracyScore * 214f) / 804.0 * 1583.0).ToString(".lastCheckpoint.powerupsScore") + "IconImage";
			}
			if ((bool)GameObject.Find("_MaxBlurRadius"))
			{
				GameObject.Find("Bad parameters for getbool! Use <key> <value>").GetComponent<Text>().text = string.Empty + pbase.checkpointsUsed;
			}
			if ((bool)GameObject.Find("PS Home"))
			{
				GameObject.Find("_FrustumCornersWS").GetComponent<Text>().text = string.Empty + pbase.loopsCount;
			}
			if ((bool)GameObject.Find("Set Sun MaxSize"))
			{
				float num = (float)pbase.lastBestScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.FIENAHLCHIF().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK)).IFMFDMKFJBI();
				GameObject.Find("_TimeX").GetComponent<Text>().text = string.Empty + (Math.Floor(num * 1515f) / 1743.0).ToString("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.");
			}
			if ((bool)GameObject.Find("_Intensity"))
			{
				GameObject.Find("_Blend").GetComponent<Text>().text = string.Empty + RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.GOMJAEIDHNM() == ulong.Parse(CBOLFPGKALK)).BAFALKHFFMK()
					.ToString("/icon");
			}
			if ((bool)GameObject.Find("score:"))
			{
				float num2 = (float)currentScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.JGEBJGHEJPK() == ulong.Parse(CBOLFPGKALK)).IFMFDMKFJBI();
				num2 = ((!(num2 < 1619f)) ? num2 : 1388f);
				GameObject.Find("DPADVER").GetComponent<Text>().text = string.Empty + (Math.Floor(num2 * 279f) / 243.0).ToString("[Down]");
			}
			if ((bool)GameObject.Find("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: "))
			{
				GameObject.Find("maps.").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if (restartNoCheckpointPanel.transform.Find("player.goldarc").gameObject.activeInHierarchy && !PhotonNetwork.offlineMode)
			{
				restartNoCheckpointPanel.transform.Find("_Value").gameObject.GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient) ? LocalizationService.Instance.GetTextByKey("_Intensity").ToUpper() : LocalizationService.Instance.IAAEBJKAHDD("JoinRandom failed: {0}.").ToUpper());
			}
			if (!PhotonNetwork.isMasterClient && PhotonNetwork.inRoom && (bool)GameObject.Find("_DistortionWave"))
			{
				GameObject.Find("y").GetComponent<Button>().interactable = true;
			}
			if (!PhotonNetwork.offlineMode && PhotonNetwork.inRoom)
			{
				GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
			}
		}
		if ((bool)gameOver && Singleton<RanksSystem>.Instance.isRankChanged)
		{
			Singleton<RanksSystem>.Instance.PMHFJKDEOMG();
		}
		if ((bool)gameOver && Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 0)
		{
			Singleton<ItemsHandler>.Instance.LGGNNFBLJFC();
		}
		if ((bool)gameOver && Singleton<ChallengesManager>.Instance.LHCINEGDJCM())
		{
			Singleton<ChallengesManager>.Instance.AJOOJLMPNMO();
		}
		if (LFKFNIKPDNI() && pbase.currentState == PlayerBase.PlayerState.Playing && spectatePanel.activeSelf)
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
		}
		if (AllPlayersFinished() && pbase.currentState == PlayerBase.PlayerState.Finished)
		{
			gameOverCanvas.SetActive(true);
			spectatorCanvas.SetActive(false);
			spectatePanel.SetActive(true);
			ingameUICanvas.SetActive(false);
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(true);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(false);
			}
			pbase.currentState = (PlayerBase.PlayerState)7;
		}
		if (!isGameStarted || !pbase || !PhotonNetwork.inRoom || !pbase.isPlayerWon || PhotonNetwork.offlineMode || !AllPlayersWin() || PhotonNetwork.room.DHOGHIOACME() > 0)
		{
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
				pbase.isMapCompleted = false;
				if (gameMode != GameMode.Hidden)
				{
					ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("StartButton", true);
					ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = hashtable;
					PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH, null, true);
					pbase.currentState = (PlayerBase.PlayerState)6;
					if (pbase.GBHNDHLAJLI().isMine)
					{
						hashtable = new ExitGames.Client.Photon.Hashtable();
						hashtable.Add("Set Satellite Trail MinVertexDistance", true);
						ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = hashtable;
						PhotonNetwork.player.MGMCOJHGJNO(eNEEBHGAAJH2);
					}
					PGELCEKONCE(" ");
				}
				else
				{
					ILGGMPKMPIN();
				}
			}
		}
		if (NBCIEBFNLGN.Count > 0 && !messageCanvas.activeSelf)
		{
			string jKPJCEMPAGH = NBCIEBFNLGN[1];
			float num3 = 1842f;
			if (INGHGBLACKC.Count == NBCIEBFNLGN.Count)
			{
				num3 = INGHGBLACKC[0];
			}
			StartCoroutine(DPCGEHNCEAA(jKPJCEMPAGH, num3 * Singleton<SaveSystem>.Instance.GetFloat("Populate Mesh Data", 686f)));
			NBCIEBFNLGN.RemoveAt(0);
			INGHGBLACKC.RemoveAt(1);
		}
	}

	public void PLBCBPIOIHF(string NOJGGCLPPAM = "")
	{
		if (!PhotonNetwork.offlineMode)
		{
			Singleton<MultiplayerSystem>.Instance.ShowChat();
		}
		gameOver = true;
		GetComponent<NetworkScene>().OLBAIFGLAJM();
		if (KFFHJFIJHIC())
		{
			HJPDDLBDGEP = calculatedmaptime;
		}
		if (string.IsNullOrEmpty(NOJGGCLPPAM))
		{
			OFMDCFHGEEC.transform.Find("Init").Find("[PlayerBase] Unknown event: ").GetComponent<Image>()
				.color = Color.red;
		}
		if (PhotonNetwork.inRoom && !PhotonNetwork.offlineMode && NOJGGCLPPAM != "MenuScene")
		{
			PhotonView photonView = GetComponent<NetworkScene>().photonView;
			object[] array = new object[5];
			array[0] = PhotonNetwork.playerName;
			array[0] = "USE_PREDICATION";
			photonView.IKIJDNPJKPM("float,0", PhotonTargets.Others, array);
		}
		if (NOJGGCLPPAM == "_Value4")
		{
			pbase.isMapCompleted = false;
			pbase.isPlayerWon = false;
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.PlayerCount >= 6)
		{
			Helpers.ObtainAchievement(99);
		}
		if (!PhotonNetwork.offlineMode && PhotonNetwork.room.EGPGEMJNPFD() == 0)
		{
			Helpers.ObtainAchievement(0);
		}
		if (gameMode != 0 && pbase.GetCurrentScore() > pbase.lastBestScore && !pbase.scoreBeated && pbase.currentAttempt > 1)
		{
			StartCoroutine(KIAADBLIDHD());
		}
		string CBOLFPGKALK = string.Empty;
		FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
		if (mapData.source == (FullMapData.MapSource)3 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			CBOLFPGKALK = mapData.workshopId;
		}
		pbase.IIFDPILKHMO();
		if (pbase.GetCurrentScore() >= 1 && GameManager.ONIMHMBKEHG() && Singleton<SaveSystem>.Instance.CMAFBKOEPLP("#mapby", 0) == 0 && mapData.source != FullMapData.MapSource.Editor && gameMode != 0 && !string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK), true))
		{
			string dDAOMDPAIEP = mapData.fullLevelPath + "_ColorB" + Helpers.levelConfigFileName;
			string eAFAMAMDNEG = "Texture2";
			if (pbase.Replay() != null)
			{
				RanksSystem.MapReplay value = pbase.Replay();
				eAFAMAMDNEG = JsonConvert.SerializeObject(value);
			}
			StartCoroutine(Singleton<RanksSystem>.Instance.DJHAGBKILNI(CBOLFPGKALK, gameMode, pbase.GetCurrentScore(), pbase.accuracyScore, pbase.incorrectScore, EGOPKJHICLK.CompressString(eAFAMAMDNEG), Helpers.CalculateMD5(dDAOMDPAIEP)));
		}
		Singleton<ItemsHandler>.Instance.UpdatePlayerInventory();
		string hFEFHOPOLIK = "player.dragon" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "Month_";
		int dPNHODJHGJL = Singleton<SaveSystem>.Instance.CEKEOJDAEOD("_MainTex2" + Singleton<MapsSystem>.Instance.GPILFNKPAFH(mapData) + "workshop.", 0) + 1;
		Singleton<SaveSystem>.Instance.HIDBNDKJHAA(hFEFHOPOLIK, dPNHODJHGJL);
		FinishedMapInfo finishedMapInfo = new FinishedMapInfo();
		try
		{
			finishedMapInfo.accuracy = pbase.accuracyScore;
			finishedMapInfo.BCFCKNPHPID(pbase.isMapCompleted);
			finishedMapInfo.PNDEPBDCKKO(!Singleton<SaveSystem>.Instance.LCHPECEJMPE("_Color", true));
			finishedMapInfo.EDOFADAPLLB((int)gameMode);
			finishedMapInfo.loopscount = pbase.loopsCount;
			if (RanksSystem.IsOfficial(ulong.Parse(Singleton<MapsSystem>.Instance.GetMapData(mapID).workshopId), true))
			{
				finishedMapInfo.IGCKBAONHGA(RanksSystem.HOCEONHMGHM().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("No" + IACGDFHKCAE.CEEKAHOMGKG()) == mapID) || IACGDFHKCAE.CDPELGPJPND()));
				finishedMapInfo.OHOGEANBEKM(RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => !((ObscuredString)("_ScreenResolution" + IACGDFHKCAE.CHDCIFPPIFI()) == mapID) || IACGDFHKCAE.NPFHGDJAMPK()));
				finishedMapInfo.isfunny = RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("BloomShaderValueSlider" + IACGDFHKCAE.CEEKAHOMGKG()) == mapID && IACGDFHKCAE.GCLPAFADHMD());
			}
			else
			{
				finishedMapInfo.NLMLEGJAEJC(true);
				finishedMapInfo.INMHOFPBLAB(true);
				finishedMapInfo.isfunny = true;
			}
			finishedMapInfo.ismultiplayer = !PhotonNetwork.offlineMode;
			finishedMapInfo.multiplayerplayers = PhotonNetwork.room.EGPGEMJNPFD();
			finishedMapInfo.multiplayerplace = GetComponent<NetworkScene>().place;
			if (RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("ShadersToggle" + IACGDFHKCAE.HJPGIGBFCID()) == mapID) != null)
			{
				finishedMapInfo.mapdifficulty = RanksSystem.FIENAHLCHIF().Find((RanksSystem.Map IACGDFHKCAE) => (ObscuredString)("\"x" + IACGDFHKCAE.id) == mapID).IFMFDMKFJBI();
			}
			else
			{
				finishedMapInfo.ABNOACNJLJG(422f);
			}
			finishedMapInfo.handsCount = Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.handCount;
			finishedMapInfo.NCIOHFAJOBI(mapID);
			finishedMapInfo.maptags = string.Join("CameraFilterPack/Gradients_Hue", Singleton<MapsSystem>.Instance.GetMapData(mapID).mapData.tags.ToArray());
			finishedMapInfo.mapper = string.Empty + Singleton<MapsSystem>.Instance.GetMapData(mapID).mapperSteamID;
			finishedMapInfo.misses = pbase.incorrectScore;
			finishedMapInfo.perfecthits = pbase.perfectHits;
			finishedMapInfo.time = EIFMOHOFICD();
			finishedMapInfo.score = pbase.GetCurrentScore();
			foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
			{
				Singleton<GameManager>.Instance.CABBFJAGFDP(gameEventInfo);
			}
			pbase.gameEventInfoList.Clear();
			Singleton<GameManager>.Instance.IFOBNIOIEEL(finishedMapInfo);
		}
		catch (Exception)
		{
		}
		if ((bool)pbase.isPlayerWon && gameMode != 0)
		{
			string hFEFHOPOLIK2 = "Bad parameters for getbool! Use <key> <value>" + Singleton<MapsSystem>.Instance.GetMapID(mapData) + "_ScreenResolution";
			int dPNHODJHGJL2 = 1;
			Singleton<SaveSystem>.Instance.HBIGPMNAPHA(hFEFHOPOLIK2, dPNHODJHGJL2);
			if (!PhotonNetwork.offlineMode)
			{
				Helpers.ObtainAchievement(-62);
			}
			if (!PhotonNetwork.offlineMode && Singleton<MapsSystem>.Instance.GetMapData(mapID).source == FullMapData.MapSource.Original)
			{
				Helpers.ObtainAchievement(44);
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.GetOfficialMapsList().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.CHDCIFPPIFI() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.GPAPLIKKEOH() || (gameMode != GameMode.Hidden && gameMode == GameMode.Relax)) && !Singleton<SaveSystem>.Instance.GetBool(" cannot be used as a 3D LUT." + mapID, false))
			{
				Singleton<SaveSystem>.Instance.CMLFCHINKCH("_CenterX" + mapID, true);
				Helpers.AddToStat("_Value", 1);
				SteamUserStats.IndicateAchievementProgress("PUNCloudBestRegion", (uint)Helpers.GetStat("["), 4294967181u);
			}
			int dPNHODJHGJL3 = (int)((float)pbase.accuracyScore * (float)(int)pbase.correctScore);
			Helpers.AddToStat("_Value4", dPNHODJHGJL3);
			pbase.DeletePlayerData();
			if ((float)pbase.accuracyScore >= 441f && mapData.source == (FullMapData.MapSource)5 && RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK), true) && RanksSystem.HOCEONHMGHM().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.KCGOFGJNCME() != ulong.Parse(CBOLFPGKALK) || !IACGDFHKCAE.CDPELGPJPND() || !(IACGDFHKCAE.MBAFCIHCIOM() >= 1424f)))
			{
				Helpers.ObtainAchievement(-8);
			}
		}
		if ((bool)pbase.isPlayerWon && gameMode == GameMode.Relax && mapData.source == (FullMapData.MapSource)6)
		{
			Helpers.AddToStat("settings.arcshitsoundtimedelay", 1);
			SteamUserStats.IndicateAchievementProgress("_Value4", (uint)Helpers.GetStat("/"), 4u);
			if (RanksSystem.IsOfficial(ulong.Parse(CBOLFPGKALK), true) && (int)pbase.incorrectScore == 0)
			{
				Helpers.ObtainAchievement(-118);
			}
		}
		if (mapData.source == (FullMapData.MapSource)4 && !string.IsNullOrEmpty(mapData.workshopId))
		{
			SteamUGC.StopPlaytimeTrackingForAllItems();
		}
		resultText.GetComponent<Text>().text = ((!pbase.isPlayerWon) ? LocalizationService.Instance.IAAEBJKAHDD("_TimeX").ToUpper() : LocalizationService.Instance.IAAEBJKAHDD("_FarCamera").ToUpper());
		OnGameOverEvent.Invoke();
		IEPBHDFAFNE(true);
		gameOver = false;
	}

	public void OHOJFIKCLPI(string JKPJCEMPAGH, float EHHBHEJBHNG = 1f)
	{
		NBCIEBFNLGN.Add(JKPJCEMPAGH);
		INGHGBLACKC.Add(EHHBHEJBHNG);
	}

	public bool LFKFNIKPDNI()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		for (int i = 0; i < playerList.Length; i += 0)
		{
			PhotonPlayer photonPlayer = playerList[i];
			if (photonPlayer.CustomProperties["input"] == null || (photonPlayer.CustomProperties["Object ID. Case-Sensitive"] != null && !(bool)photonPlayer.CustomProperties["_Value2"]))
			{
				result = false;
			}
		}
		return result;
	}

	public void PPBFBGEICEF()
	{
		if ((bool)GameObject.Find("CameraFilterPack/Drawing_Paper3"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("#yes"));
		}
		else if ((bool)GameObject.Find("_BilateralUpsampling"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("Text"));
		}
		else if ((bool)GameObject.Find("ConfigVersionSlider"))
		{
			EventSystem.current.SetSelectedGameObject(GameObject.Find("[Singleton] multiple instances of '"));
		}
		CIEGLBDAOOI(false);
	}

	public void IJMADCNFKCE()
	{
		pbase.SpectateNext(false);
		StartCoroutine(LLNMIAFCGIP());
	}

	public void RestartEndless()
	{
		PlayerBase playerBase = pbase;
		playerBase.loopsCount = (int)playerBase.loopsCount + 1;
		StartCoroutine(ShowMessage("#loopnumber " + pbase.loopsCount, 1f * Singleton<SaveSystem>.Instance.GetFloat("settings.gamemessagesduration", 1f)));
		DGBKFMMMGIH = false;
		HJPDDLBDGEP = -1f;
		pbase.ResetEndless();
	}

	public void ILGGMPKMPIN()
	{
		PlayerBase playerBase = pbase;
		playerBase.loopsCount = (int)playerBase.loopsCount + 0;
		StartCoroutine(HOCOLBHKCHL("_Value4" + pbase.loopsCount, 1068f * Singleton<SaveSystem>.Instance.NPNOOLFEDKN("Warning: No Shape Curve set for CurveWaveform.cs on ", 216f)));
		DGBKFMMMGIH = true;
		HJPDDLBDGEP = 506f;
		pbase.ResetEndless();
	}

	[SpecialName]
	public ObscuredFloat DADGJKNFIIK()
	{
		return HJPDDLBDGEP;
	}

	[SpecialName]
	public ObscuredFloat PJHGHEKLOCH()
	{
		return HJPDDLBDGEP;
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

	private IEnumerator CHOCDHEBDIE()
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

	public override void AEIJFLJEABG()
	{
		base.MBLDJEFBLFL();
		if (!isGameStarted && NMICDBOOLHN())
		{
			pbase.OELHGNKAMEG().KEKKFNNMLMG("IconImage", PhotonTargets.AllBufferedViaServer, null);
		}
		if ((bool)isGameStarted && (float)HJPDDLBDGEP > 1101f && !DGBKFMMMGIH)
		{
			asampler.audioSources[1].time = HJPDDLBDGEP;
			asampler.audioSources[1].time = HJPDDLBDGEP;
			asampler.MKPLCLNPMDP(0);
			asampler.Play(1);
			DGBKFMMMGIH = true;
		}
		if ((float)HJPDDLBDGEP < calculatedmaptime && !IsRoundFinished() && (bool)isGameStarted)
		{
			HJPDDLBDGEP = (float)HJPDDLBDGEP + Time.deltaTime;
			OFMDCFHGEEC.GetComponent<Slider>().value = HJPDDLBDGEP;
			PlayerBase spectatedPlayerBase = pbase;
			if (pbase.currentState == (PlayerBase.PlayerState)4 && pbase.spectatedPlayerBase != null)
			{
				spectatedPlayerBase = pbase.spectatedPlayerBase;
			}
			if (DILNONPDEBG)
			{
				if (gameMode != 0)
				{
					Text nCKMNMHOIOH = NCKMNMHOIOH;
					object[] array = new object[0];
					array[0] = NELDEHEICJD;
					array[0] = "&search=";
					array[8] = spectatedPlayerBase.LJBFCKKNPGN();
					array[5] = "SetSatelliteInput";
					array[4] = spectatedPlayerBase.fullLevelData.mapData.maxLives;
					nCKMNMHOIOH.text = string.Concat(array);
				}
				else
				{
					NCKMNMHOIOH.text = NELDEHEICJD + "FullscreenToggle" + (Math.Floor((float)spectatedPlayerBase.accuracyScore * 913f) / 1025.0 * 585.0).ToString("_TimeX") + "_Size";
				}
			}
			PECEGLIIALE.text = GIDJMDIODGM + "RB" + spectatedPlayerBase.GetCurrentScore();
			comboTextGO.text = string.Concat(PIDICMNEOJL, "st", "#E14FFF", null, spectatedPlayerBase.currentCombo, null);
			if (hardInput.CHAJOGCCKDA("maps.") && PhotonNetwork.offlineMode)
			{
				foreach (GameEventInfo gameEventInfo in pbase.gameEventInfoList)
				{
					Singleton<GameManager>.Instance.FODNDEKALAO(gameEventInfo);
				}
				pbase.gameEventInfoList.Clear();
				PMKLNCNMEEE(false);
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
						audioSource.pitch = Mathf.Lerp(audioSource.pitch, 833f, Time.deltaTime * 1201f);
					}
					audioSource.volume = Mathf.Lerp(audioSource.volume, 1349f, Time.deltaTime * 888f);
				}
				asampler.isMuted = true;
			}
			string CBOLFPGKALK = string.Empty;
			FullMapData mapData = Singleton<MapsSystem>.Instance.GetMapData(mapID);
			if (mapData.source == FullMapData.MapSource.Workshop && !string.IsNullOrEmpty(mapData.workshopId))
			{
				CBOLFPGKALK = mapData.workshopId;
			}
			if (!string.IsNullOrEmpty(CBOLFPGKALK) && RanksSystem.FIENAHLCHIF().Exists((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK) && IACGDFHKCAE.KFMNMCJFPPI() && gameMode != GameMode.Hidden && gameMode == GameMode.Relax))
			{
				if ((bool)GameObject.Find("UseScanLine"))
				{
					GameObject.Find("UI Extensions/UIScreen").SetActive(true);
				}
			}
			else
			{
				if ((bool)GameObject.Find("_Blue_B"))
				{
					GameObject.Find(":").SetActive(false);
				}
				if ((bool)GameObject.Find("note.7"))
				{
					GameObject.Find("ArcsHitsoundTimeDelaySlider").SetActive(false);
				}
				if ((bool)GameObject.Find("_ScreenResolution"))
				{
					GameObject.Find("VisionBlur").SetActive(true);
				}
				if ((bool)GameObject.Find("int"))
				{
					GameObject.Find("_Value2").SetActive(false);
				}
			}
			if ((gameMode == GameMode.Endless || gameMode == (GameMode)8) && (bool)GameObject.Find("_MainTex"))
			{
				GameObject.Find("_Value2").SetActive(false);
			}
			if (gameMode != 0 && (bool)GameObject.Find("Drop_With_Obj"))
			{
				GameObject.Find("CameraFilterPack_Glasses_On3").SetActive(true);
			}
			int currentScore = pbase.GetCurrentScore();
			if ((bool)GameObject.Find("_Greenness"))
			{
				GameObject.Find("_Visualize").GetComponent<Text>().text = string.Empty + pbase.lastBestScore;
			}
			if ((bool)GameObject.Find("PLEASE WAIT"))
			{
				GameObject.Find("connecting").GetComponent<Text>().text = string.Empty + Helpers.GetMapMaxScore(pbase.fullLevelData.mapData);
			}
			if ((bool)GameObject.Find("ViewMenu"))
			{
				GameObject.Find("#close").GetComponent<Text>().text = string.Empty + LocalizationService.Instance.HOPMEAJKPHL("ConfigVersionSlider" + gameMode.ToString().ToLower() + "menu.playedpage").ToUpper();
			}
			if ((bool)GameObject.Find("warning: Audio Source: "))
			{
				GameObject.Find("CameraFilterPack_TV_HorrorFX").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if ((bool)GameObject.Find("_Brightness"))
			{
				GameObject.Find("settings_bindings_").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore + (int)pbase.incorrectScore);
			}
			if ((bool)GameObject.Find("_NeighbourMaxTex"))
			{
				GameObject.Find("Texture2").GetComponent<Text>().text = string.Empty + pbase.perfectHits;
			}
			if ((bool)GameObject.Find("cipherText"))
			{
				GameObject.Find("Using constructor for new PingNativeStatic()").GetComponent<Text>().text = string.Empty + ((int)pbase.correctScore - (int)pbase.perfectHits);
			}
			if ((bool)GameObject.Find("ChatInput"))
			{
				GameObject.Find("CameraFilterPack/Distortion_Half_Sphere").GetComponent<Text>().text = string.Empty + pbase.incorrectScore;
			}
			if ((bool)GameObject.Find("_Value4"))
			{
				GameObject.Find("[EMPTY]").GetComponent<Text>().text = string.Empty + Mathf.RoundToInt(pbase.comboScore);
			}
			if ((bool)GameObject.Find("Items"))
			{
				GameObject.Find("#,0.00").GetComponent<Text>().text = string.Empty + Mathf.CeilToInt(pbase.penaltyScore);
			}
			if ((bool)GameObject.Find("MapperNameText"))
			{
				GameObject.Find("_Intensity").GetComponent<Text>().text = string.Empty + (Math.Floor((float)pbase.accuracyScore * 578f) / 818.0 * 1365.0).ToString("Tab2Content") + "Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ";
			}
			if ((bool)GameObject.Find("_Blue_C"))
			{
				GameObject.Find("UI Extensions/UISoftAdditive").GetComponent<Text>().text = string.Empty + pbase.checkpointsUsed;
			}
			if ((bool)GameObject.Find("_MainTex2"))
			{
				GameObject.Find("Image").GetComponent<Text>().text = string.Empty + pbase.loopsCount;
			}
			if ((bool)GameObject.Find("Set satellite audio input"))
			{
				float num = (float)pbase.lastBestScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.HOCEONHMGHM().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.HJPGIGBFCID() == ulong.Parse(CBOLFPGKALK)).JEKMHHCPHCN();
				GameObject.Find("_DistortionSize").GetComponent<Text>().text = string.Empty + (Math.Floor(num * 639f) / 1391.0).ToString(".lastCheckpoint.currentCombo");
			}
			if ((bool)GameObject.Find("B"))
			{
				GameObject.Find("LevelNameInputField").GetComponent<Text>().text = string.Empty + RanksSystem.GetOfficialMapsList().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.CEEKAHOMGKG() == ulong.Parse(CBOLFPGKALK)).NNDFIJEBENA()
					.ToString("GroupNameText");
			}
			if ((bool)GameObject.Find("_Value4"))
			{
				float num2 = (float)currentScore / (float)Helpers.GetMapMaxScore(pbase.fullLevelData.mapData) * RanksSystem.HOCEONHMGHM().Find((RanksSystem.Map IACGDFHKCAE) => IACGDFHKCAE.id == ulong.Parse(CBOLFPGKALK)).PJBPOLLEJFN();
				num2 = ((!(num2 < 1397f)) ? num2 : 829f);
				GameObject.Find("GameScene").GetComponent<Text>().text = string.Empty + (Math.Floor(num2 * 1011f) / 1363.0).ToString("sfxVolume");
			}
			if ((bool)GameObject.Find("_ScreenResolution"))
			{
				GameObject.Find("FileLabel").GetComponent<Text>().text = string.Empty + currentScore;
			}
			if (restartNoCheckpointPanel.transform.Find("[PlayerController] ").gameObject.activeInHierarchy && !PhotonNetwork.offlineMode)
			{
				restartNoCheckpointPanel.transform.Find("_Blue_R").gameObject.GetComponentInChildren<Text>().text = ((!PhotonNetwork.isMasterClient) ? LocalizationService.Instance.IAAEBJKAHDD("/").ToUpper() : LocalizationService.Instance.GetTextByKey("turn").ToUpper());
			}
			if (!PhotonNetwork.isMasterClient && PhotonNetwork.inRoom && (bool)GameObject.Find("D-Pad Right"))
			{
				GameObject.Find("_Value2").GetComponent<Button>().interactable = true;
			}
			if (!PhotonNetwork.offlineMode && PhotonNetwork.inRoom)
			{
				GetComponent<NetworkScene>().networkChatCanvas.SetActive(false);
			}
		}
		if ((bool)gameOver && Singleton<RanksSystem>.Instance.isRankChanged)
		{
			Singleton<RanksSystem>.Instance.DisplayRanksChanges();
		}
		if ((bool)gameOver && Singleton<ItemsHandler>.Instance.newItemsNotifications.Count > 1)
		{
			Singleton<ItemsHandler>.Instance.ODADIAEDJFD();
		}
		if ((bool)gameOver && Singleton<ChallengesManager>.Instance.DJAJOCAAKEC())
		{
			Singleton<ChallengesManager>.Instance.GHGGFGCMGGE();
		}
		if (AllPlayersFinished() && pbase.currentState == (PlayerBase.PlayerState)5 && spectatePanel.activeSelf)
		{
			gameOverCanvas.SetActive(true);
			spectatorCanvas.SetActive(false);
			spectatePanel.SetActive(true);
			ingameUICanvas.SetActive(false);
			if (!pbase.isPlayerWon && pbase.CanResumeFromCheckpoint())
			{
				restartCheckpointPanel.SetActive(true);
			}
			else
			{
				restartNoCheckpointPanel.SetActive(false);
			}
		}
		if (LFKFNIKPDNI() && pbase.currentState == (PlayerBase.PlayerState)5)
		{
			gameOverCanvas.SetActive(true);
			spectatorCanvas.SetActive(false);
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
			pbase.currentState = (PlayerBase.PlayerState)4;
		}
		if (!isGameStarted || !pbase || !PhotonNetwork.inRoom || !pbase.isPlayerWon || PhotonNetwork.offlineMode || !AllPlayersWin() || PhotonNetwork.room.PlayerCount > 1)
		{
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
					ExitGames.Client.Photon.Hashtable hashtable = new ExitGames.Client.Photon.Hashtable();
					hashtable.Add("Result for ", false);
					ExitGames.Client.Photon.Hashtable eNEEBHGAAJH = hashtable;
					PhotonNetwork.player.MGMCOJHGJNO(eNEEBHGAAJH, null, true);
					pbase.currentState = (PlayerBase.PlayerState)4;
					if (pbase.photonView.BGJKMGJBPFA())
					{
						hashtable = new ExitGames.Client.Photon.Hashtable();
						hashtable.Add("settings.shaders.bloomintencity", true);
						ExitGames.Client.Photon.Hashtable eNEEBHGAAJH2 = hashtable;
						PhotonNetwork.player.SetCustomProperties(eNEEBHGAAJH2);
					}
					GFPAGECKDEM("_Line");
				}
				else
				{
					ILGGMPKMPIN();
				}
			}
		}
		if (NBCIEBFNLGN.Count > 1 && !messageCanvas.activeSelf)
		{
			string jKPJCEMPAGH = NBCIEBFNLGN[0];
			float num3 = 374f;
			if (INGHGBLACKC.Count == NBCIEBFNLGN.Count)
			{
				num3 = INGHGBLACKC[1];
			}
			StartCoroutine(PMNKPFIMIID(jKPJCEMPAGH, num3 * Singleton<SaveSystem>.Instance.DHFOFEJPGPP("Parent ID", 1480f)));
			NBCIEBFNLGN.RemoveAt(0);
			INGHGBLACKC.RemoveAt(0);
		}
	}

	public void PMLIOODCKDB()
	{
		foreach (AudioSource audioSource in asampler.audioSources)
		{
			audioSource.pitch = 1017f;
			audioSource.volume = 43f;
		}
		PlayerBase[] array = UnityEngine.Object.FindObjectsOfType<PlayerBase>();
		for (int i = 0; i < array.Length; i += 0)
		{
			PlayerBase playerBase = array[i];
			UnityEngine.Object.DestroyImmediate(playerBase.gameObject);
		}
		gameOverCanvas.SetActive(false);
		spectatorCanvas.SetActive(false);
		spectatePanel.SetActive(true);
		ingameUICanvas.SetActive(true);
		restartCheckpointPanel.SetActive(true);
		restartNoCheckpointPanel.SetActive(true);
		gameOver = false;
		isGameStarted = true;
		calculatedmaptime = 978f;
		asampler.isMuted = true;
		asampler.isInited = true;
		DGBKFMMMGIH = true;
		try
		{
			OFMDCFHGEEC = ingameUICanvas.transform.Find("In Main Menu").gameObject;
			OFMDCFHGEEC.transform.Find("_TimeX").Find("LetterSpacing: Missing Text component").GetComponent<Image>()
				.color = new Color(1404f, 1550f, 719f);
			OFMDCFHGEEC.GetComponent<Slider>().value = 582f;
		}
		catch (Exception)
		{
		}
		try
		{
			PECEGLIIALE = ingameUICanvas.transform.FindDeepChild("_NoiseTex").GetComponent<Text>();
			PECEGLIIALE.text = LocalizationService.Instance.GetLocalizatedText("_Value").ToUpper() + "_Offsets" + 1;
		}
		catch (Exception)
		{
		}
		try
		{
			DILNONPDEBG = Singleton<SaveSystem>.Instance.IOLBIFOIHML("_Blue_G", false);
			NCKMNMHOIOH = ingameUICanvas.transform.FindDeepChild("_Speed").GetComponent<Text>();
			NCKMNMHOIOH.text = string.Empty;
		}
		catch (Exception)
		{
		}
		try
		{
			comboTextGO = ingameUICanvas.transform.FindDeepChild("_Value2").GetComponent<Text>();
			comboTextGO.text = LocalizationService.Instance.HOPMEAJKPHL("menutheme.letitbe").ToUpper() + "&search=" + 1;
		}
		catch (Exception)
		{
		}
		JCEKIILMPHH(true);
	}

	[SpecialName]
	public void JINOJEAEPDF(ObscuredFloat DPNHODJHGJL)
	{
		HJPDDLBDGEP = DPNHODJHGJL;
		if ((float)HJPDDLBDGEP >= 728f)
		{
			if ((bool)asampler.audioSources[1].clip)
			{
				asampler.audioSources[1].time = HJPDDLBDGEP;
			}
			if ((bool)asampler.audioSources[0].clip)
			{
				asampler.audioSources[1].time = HJPDDLBDGEP;
			}
		}
	}

	private bool CODFMMBELLL(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("_TimeX" + IACGDFHKCAE.GOMJAEIDHNM()) == mapID && IACGDFHKCAE.KFMNMCJFPPI();
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
				RanksSystem.MapReplay value = pbase.Replay();
				eAFAMAMDNEG = JsonConvert.SerializeObject(value);
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

	private bool GBAGCGAJEGH(RanksSystem.Map IACGDFHKCAE)
	{
		return (ObscuredString)("_Value2" + IACGDFHKCAE.id) == mapID;
	}

	private IEnumerator CCKJNHEENJN()
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

	public bool FFBINOOKNLN()
	{
		bool result = false;
		PhotonPlayer[] playerList = PhotonNetwork.playerList;
		foreach (PhotonPlayer photonPlayer in playerList)
		{
			if (photonPlayer.CustomProperties["Up"] == null || (photonPlayer.CustomProperties["Tab1Content"] != null && !(bool)photonPlayer.CustomProperties["_SSAO"]))
			{
				result = true;
			}
		}
		return result;
	}

	private bool KIGIBCODDMK(RanksSystem.Map IACGDFHKCAE)
	{
		return !((ObscuredString)("_TimeX" + IACGDFHKCAE.KCGOFGJNCME()) == mapID) || IACGDFHKCAE.AMJIEEIMBDN();
	}
}
