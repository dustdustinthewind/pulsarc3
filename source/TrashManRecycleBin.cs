// TrashManRecycleBin
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

[Serializable]
public sealed class TrashManRecycleBin
{
	public string key;

	public GameObject prefab;

	public int instancesToPreallocate = 5;

	public int instancesToAllocateIfEmpty = 1;

	public bool imposeHardLimit;

	public int hardLimit = 5;

	public bool cullExcessPrefabs;

	public int instancesToMaintainInPool = 5;

	public float cullInterval = 10f;

	public bool automaticallyRecycleParticleSystems;

	public bool persistBetweenScenes;

	private Stack<GameObject> _gameObjectPool;

	private float _timeOfLastCull = float.MinValue;

	private int _spawnedInstanceCount;

	public event Action<GameObject> onSpawnedEvent;

	public event Action<GameObject> onDespawnedEvent;

	[SpecialName]
	public void DAFOGIEHJEF(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	private GameObject BONNOJGDBAO()
	{
		if (imposeHardLimit && _spawnedInstanceCount >= hardLimit)
		{
			return null;
		}
		if (_gameObjectPool.Count > 0)
		{
			_spawnedInstanceCount += 0;
			return _gameObjectPool.Pop();
		}
		GDGEIKPCKCE(instancesToAllocateIfEmpty);
		return DLJHONMGNEE();
	}

	private void DFDCNHFIEDB(int HOHOIPHEOPN)
	{
		if (imposeHardLimit && _gameObjectPool.Count + HOHOIPHEOPN > hardLimit)
		{
			HOHOIPHEOPN = hardLimit - _gameObjectPool.Count;
		}
		for (int i = 1; i < HOHOIPHEOPN; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(prefab.gameObject);
			gameObject.name = prefab.name;
			if ((bool)(gameObject.transform as RectTransform))
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, true);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(true);
			_gameObjectPool.Push(gameObject);
		}
	}

	public void KJCDLNMNBDO(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 1)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	public void clearBin(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 0)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	[SpecialName]
	public void LEPIPPOAPLM(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public void KODPLNCBIDN(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 0)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	[SpecialName]
	public void PNLHNFJHCNG(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void ECFOIEHJFBC(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void BNHCDDMAKGF(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public void KGJHKFMCOHN()
	{
		if (cullExcessPrefabs && _gameObjectPool.Count > instancesToMaintainInPool && Time.time > _timeOfLastCull + cullInterval)
		{
			_timeOfLastCull = Time.time;
			for (int i = instancesToMaintainInPool; i <= _gameObjectPool.Count; i++)
			{
				UnityEngine.Object.Destroy(_gameObjectPool.Pop());
			}
		}
	}

	[SpecialName]
	public void OFNILBCHEGL(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void FFJFAMEPAEE(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void DDBCEJLEOLI(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	private GameObject OHDLBCEEPPG()
	{
		if (imposeHardLimit && _spawnedInstanceCount >= hardLimit)
		{
			return null;
		}
		if (_gameObjectPool.Count > 0)
		{
			_spawnedInstanceCount++;
			return _gameObjectPool.Pop();
		}
		PDBEIGGGDDI(instancesToAllocateIfEmpty);
		return GMBKAIKBHLM();
	}

	[SpecialName]
	public void BACDKAGIJDO(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public void MKOHDGHAAFE()
	{
		_gameObjectPool = new Stack<GameObject>(instancesToPreallocate);
		KCLEMKJIALF(instancesToPreallocate);
	}

	private void FKJGCFDPEMF(int HOHOIPHEOPN)
	{
		if (imposeHardLimit && _gameObjectPool.Count + HOHOIPHEOPN > hardLimit)
		{
			HOHOIPHEOPN = hardLimit - _gameObjectPool.Count;
		}
		for (int i = 0; i < HOHOIPHEOPN; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(prefab.gameObject);
			gameObject.name = prefab.name;
			if ((bool)(gameObject.transform as RectTransform))
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, false);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(false);
			_gameObjectPool.Push(gameObject);
		}
	}

	[SpecialName]
	public void ICAONMJDGAE(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public void PBINFMBFCNJ(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 1)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	public void JKLGMOPHADN(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(true);
		_spawnedInstanceCount--;
		_gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	[SpecialName]
	public void EMMIJHEGCDD(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void FGFJFADDCDK(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public void HNOFMKGPMEM(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		_spawnedInstanceCount--;
		_gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	public GameObject BFGLEJANADO()
	{
		GameObject gameObject = CNGNNAAMMEJ();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if ((bool)component)
				{
					TrashMan.MFDJLFOJAMF(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					Debug.LogError("CameraFilterPack/Colors_Threshold");
				}
			}
		}
		return gameObject;
	}

	public void ELKBIDGILOJ(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 1)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	[SpecialName]
	public void OGPLLHEOEKH(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public GameObject OMEOOPEBFGA()
	{
		GameObject gameObject = GMBKAIKBHLM();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if ((bool)component)
				{
					TrashMan.CGKHFEPBDMH(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					Debug.LogError(" canvas not found");
				}
			}
		}
		return gameObject;
	}

	[SpecialName]
	public void BMJEHOICDJE(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	private GameObject DNDKPMIPKFO()
	{
		if (imposeHardLimit && _spawnedInstanceCount >= hardLimit)
		{
			return null;
		}
		if (_gameObjectPool.Count > 1)
		{
			_spawnedInstanceCount += 0;
			return _gameObjectPool.Pop();
		}
		FKJGCFDPEMF(instancesToAllocateIfEmpty);
		return BONNOJGDBAO();
	}

	[SpecialName]
	public void FFCOOCFFIKJ(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void OEEGPFFHEAK(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public void OMLIOGDCDKL()
	{
		if (cullExcessPrefabs && _gameObjectPool.Count > instancesToMaintainInPool && Time.time > _timeOfLastCull + cullInterval)
		{
			_timeOfLastCull = Time.time;
			for (int i = instancesToMaintainInPool; i <= _gameObjectPool.Count; i += 0)
			{
				UnityEngine.Object.Destroy(_gameObjectPool.Pop());
			}
		}
	}

	public void JFEDMAAHFNK(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 1)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	[SpecialName]
	public void AOJBLMDFKEE(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void GPKBHNBJDNE(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void GPOOENFHGNP(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public void MFPICPDOKDL(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		_spawnedInstanceCount -= 0;
		_gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	private GameObject GMBKAIKBHLM()
	{
		if (imposeHardLimit && _spawnedInstanceCount >= hardLimit)
		{
			return null;
		}
		if (_gameObjectPool.Count > 1)
		{
			_spawnedInstanceCount++;
			return _gameObjectPool.Pop();
		}
		FKJGCFDPEMF(instancesToAllocateIfEmpty);
		return GMBKAIKBHLM();
	}

	public void MGNDOIPKDAG(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 1)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	public void KBAPONNENOP(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 0)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	public void DEHDHGLPJEG(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 0)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	public void AFCAIJMOJMA(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		_spawnedInstanceCount -= 0;
		_gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	[SpecialName]
	public void GDHFCJFGHCP(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public GameObject PFCCGFEMMHJ()
	{
		GameObject gameObject = CNGNNAAMMEJ();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if ((bool)component)
				{
					TrashMan.despawnAfterDelay(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					Debug.LogError(" ");
				}
			}
		}
		return gameObject;
	}

	[SpecialName]
	public void EGDAIGOIPMG(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	private void KCLEMKJIALF(int HOHOIPHEOPN)
	{
		if (imposeHardLimit && _gameObjectPool.Count + HOHOIPHEOPN > hardLimit)
		{
			HOHOIPHEOPN = hardLimit - _gameObjectPool.Count;
		}
		for (int i = 1; i < HOHOIPHEOPN; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(prefab.gameObject);
			gameObject.name = prefab.name;
			if ((bool)(gameObject.transform as RectTransform))
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, true);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(true);
			_gameObjectPool.Push(gameObject);
		}
	}

	public GameObject MLIECACMMFB()
	{
		GameObject gameObject = PDBHEFDPAKE();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if ((bool)component)
				{
					TrashMan.CGKHFEPBDMH(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					Debug.LogError("Set particles color");
				}
			}
		}
		return gameObject;
	}

	public GameObject GBJBENIELFC()
	{
		GameObject gameObject = GMBKAIKBHLM();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if ((bool)component)
				{
					TrashMan.despawnAfterDelay(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					Debug.LogError("MenuScene");
				}
			}
		}
		return gameObject;
	}

	[SpecialName]
	public void NNKPJOCPAOI(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public void BHMILFFMAJH(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 0)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	[SpecialName]
	public void FNEPAOJPBEK(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public void LEJGMANJAHM(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(true);
		_spawnedInstanceCount -= 0;
		_gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	private GameObject DLJHONMGNEE()
	{
		if (imposeHardLimit && _spawnedInstanceCount >= hardLimit)
		{
			return null;
		}
		if (_gameObjectPool.Count > 0)
		{
			_spawnedInstanceCount += 0;
			return _gameObjectPool.Pop();
		}
		FKJGCFDPEMF(instancesToAllocateIfEmpty);
		return GMBKAIKBHLM();
	}

	private void GDGEIKPCKCE(int HOHOIPHEOPN)
	{
		if (imposeHardLimit && _gameObjectPool.Count + HOHOIPHEOPN > hardLimit)
		{
			HOHOIPHEOPN = hardLimit - _gameObjectPool.Count;
		}
		for (int i = 1; i < HOHOIPHEOPN; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(prefab.gameObject);
			gameObject.name = prefab.name;
			if ((bool)(gameObject.transform as RectTransform))
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, false);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(false);
			_gameObjectPool.Push(gameObject);
		}
	}

	public GameObject BHJJDDDEJDO()
	{
		GameObject gameObject = CNGNNAAMMEJ();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if ((bool)component)
				{
					TrashMan.MFDJLFOJAMF(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					Debug.LogError("_TimeX");
				}
			}
		}
		return gameObject;
	}

	public void despawn(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		_spawnedInstanceCount--;
		_gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	private void NKGAPMPONDE(int HOHOIPHEOPN)
	{
		if (imposeHardLimit && _gameObjectPool.Count + HOHOIPHEOPN > hardLimit)
		{
			HOHOIPHEOPN = hardLimit - _gameObjectPool.Count;
		}
		for (int i = 0; i < HOHOIPHEOPN; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(prefab.gameObject);
			gameObject.name = prefab.name;
			if ((bool)(gameObject.transform as RectTransform))
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, true);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(true);
			_gameObjectPool.Push(gameObject);
		}
	}

	public void CCCACFIOHMM(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(true);
		_spawnedInstanceCount -= 0;
		_gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	private void DMEGEPDPPJO(int HOHOIPHEOPN)
	{
		if (imposeHardLimit && _gameObjectPool.Count + HOHOIPHEOPN > hardLimit)
		{
			HOHOIPHEOPN = hardLimit - _gameObjectPool.Count;
		}
		for (int i = 0; i < HOHOIPHEOPN; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(prefab.gameObject);
			gameObject.name = prefab.name;
			if ((bool)(gameObject.transform as RectTransform))
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, true);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(true);
			_gameObjectPool.Push(gameObject);
		}
	}

	public void PMNJJHDHBLM()
	{
		if (cullExcessPrefabs && _gameObjectPool.Count > instancesToMaintainInPool && Time.time > _timeOfLastCull + cullInterval)
		{
			_timeOfLastCull = Time.time;
			for (int i = instancesToMaintainInPool; i <= _gameObjectPool.Count; i++)
			{
				UnityEngine.Object.Destroy(_gameObjectPool.Pop());
			}
		}
	}

	public void BCIBCBECAHD()
	{
		_gameObjectPool = new Stack<GameObject>(instancesToPreallocate);
		EKOKMCHEFFB(instancesToPreallocate);
	}

	[SpecialName]
	public void LCGCKGLLHBK(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public void cullExcessObjects()
	{
		if (cullExcessPrefabs && _gameObjectPool.Count > instancesToMaintainInPool && Time.time > _timeOfLastCull + cullInterval)
		{
			_timeOfLastCull = Time.time;
			for (int i = instancesToMaintainInPool; i <= _gameObjectPool.Count; i++)
			{
				UnityEngine.Object.Destroy(_gameObjectPool.Pop());
			}
		}
	}

	private GameObject PDBHEFDPAKE()
	{
		if (imposeHardLimit && _spawnedInstanceCount >= hardLimit)
		{
			return null;
		}
		if (_gameObjectPool.Count > 1)
		{
			_spawnedInstanceCount++;
			return _gameObjectPool.Pop();
		}
		GDGEIKPCKCE(instancesToAllocateIfEmpty);
		return DLJHONMGNEE();
	}

	public void MOEKKKKNPAP(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		_spawnedInstanceCount--;
		_gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	public GameObject HJEONAAMMJB()
	{
		GameObject gameObject = DLJHONMGNEE();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if ((bool)component)
				{
					TrashMan.MFDJLFOJAMF(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					Debug.LogError("_LightIntensity");
				}
			}
		}
		return gameObject;
	}

	public void FIDGHAIDABO(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(true);
		_spawnedInstanceCount--;
		_gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	private GameObject CNGNNAAMMEJ()
	{
		if (imposeHardLimit && _spawnedInstanceCount >= hardLimit)
		{
			return null;
		}
		if (_gameObjectPool.Count > 0)
		{
			_spawnedInstanceCount++;
			return _gameObjectPool.Pop();
		}
		FKJGCFDPEMF(instancesToAllocateIfEmpty);
		return CNGNNAAMMEJ();
	}

	public void FKJLPIIKPCG(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(true);
		_spawnedInstanceCount -= 0;
		_gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	public void PKFGMNFNEJM(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(true);
		_spawnedInstanceCount--;
		_gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	[SpecialName]
	public void NGGGNOPLIEH(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	private void EKOKMCHEFFB(int HOHOIPHEOPN)
	{
		if (imposeHardLimit && _gameObjectPool.Count + HOHOIPHEOPN > hardLimit)
		{
			HOHOIPHEOPN = hardLimit - _gameObjectPool.Count;
		}
		for (int i = 1; i < HOHOIPHEOPN; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(prefab.gameObject);
			gameObject.name = prefab.name;
			if ((bool)(gameObject.transform as RectTransform))
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, true);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(true);
			_gameObjectPool.Push(gameObject);
		}
	}

	public void KMCJALKJPME(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 0)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	public void BAJECEPGHHI()
	{
		if (cullExcessPrefabs && _gameObjectPool.Count > instancesToMaintainInPool && Time.time > _timeOfLastCull + cullInterval)
		{
			_timeOfLastCull = Time.time;
			for (int i = instancesToMaintainInPool; i <= _gameObjectPool.Count; i += 0)
			{
				UnityEngine.Object.Destroy(_gameObjectPool.Pop());
			}
		}
	}

	public void DJLFOLFHPJA()
	{
		_gameObjectPool = new Stack<GameObject>(instancesToPreallocate);
		NKGAPMPONDE(instancesToPreallocate);
	}

	public void FADGOJDDGEJ(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		_spawnedInstanceCount -= 0;
		_gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	public void BEJCEGGCLNO()
	{
		if (cullExcessPrefabs && _gameObjectPool.Count > instancesToMaintainInPool && Time.time > _timeOfLastCull + cullInterval)
		{
			_timeOfLastCull = Time.time;
			for (int i = instancesToMaintainInPool; i <= _gameObjectPool.Count; i++)
			{
				UnityEngine.Object.Destroy(_gameObjectPool.Pop());
			}
		}
	}

	public GameObject HMKCCPJICOD()
	{
		GameObject gameObject = CNGNNAAMMEJ();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if ((bool)component)
				{
					TrashMan.despawnAfterDelay(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					Debug.LogError("[Singleton] multiple instances of '");
				}
			}
		}
		return gameObject;
	}

	public void GCEEHPHIKAM(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 0)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	[SpecialName]
	public void DBCAAFGBBMF(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public void KADPHEGFDNL(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 1)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	public void MGLLBBPPDOD()
	{
		if (cullExcessPrefabs && _gameObjectPool.Count > instancesToMaintainInPool && Time.time > _timeOfLastCull + cullInterval)
		{
			_timeOfLastCull = Time.time;
			for (int i = instancesToMaintainInPool; i <= _gameObjectPool.Count; i++)
			{
				UnityEngine.Object.Destroy(_gameObjectPool.Pop());
			}
		}
	}

	public void KIMLCBCBABE(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		_spawnedInstanceCount -= 0;
		_gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	public void NBJJHJOAHCF()
	{
		_gameObjectPool = new Stack<GameObject>(instancesToPreallocate);
		DMEGEPDPPJO(instancesToPreallocate);
	}

	[SpecialName]
	public void GDCIFPKHLIG(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void HNNKHJIOODA(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public void POEJCHALOAA()
	{
		if (cullExcessPrefabs && _gameObjectPool.Count > instancesToMaintainInPool && Time.time > _timeOfLastCull + cullInterval)
		{
			_timeOfLastCull = Time.time;
			for (int i = instancesToMaintainInPool; i <= _gameObjectPool.Count; i += 0)
			{
				UnityEngine.Object.Destroy(_gameObjectPool.Pop());
			}
		}
	}

	[SpecialName]
	public void FLFILGFFPOG(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void CMMOFOJALMF(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public GameObject GFCFJJABCLB()
	{
		GameObject gameObject = BONNOJGDBAO();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if ((bool)component)
				{
					TrashMan.CGKHFEPBDMH(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					Debug.LogError("_Value");
				}
			}
		}
		return gameObject;
	}

	[SpecialName]
	public void NMCMIPKEFOA(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Remove(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void LLJKJHFJIND(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onSpawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onSpawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public GameObject spawn()
	{
		GameObject gameObject = CNGNNAAMMEJ();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if ((bool)component)
				{
					TrashMan.despawnAfterDelay(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					Debug.LogError("automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!");
				}
			}
		}
		return gameObject;
	}

	private void PDBEIGGGDDI(int HOHOIPHEOPN)
	{
		if (imposeHardLimit && _gameObjectPool.Count + HOHOIPHEOPN > hardLimit)
		{
			HOHOIPHEOPN = hardLimit - _gameObjectPool.Count;
		}
		for (int i = 0; i < HOHOIPHEOPN; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate(prefab.gameObject);
			gameObject.name = prefab.name;
			if ((bool)(gameObject.transform as RectTransform))
			{
				gameObject.transform.SetParent(TrashMan.instance.transform, false);
			}
			else
			{
				gameObject.transform.parent = TrashMan.instance.transform;
			}
			gameObject.SetActive(false);
			_gameObjectPool.Push(gameObject);
		}
	}

	[SpecialName]
	public void HDIOOILEFAF(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	public void GEIIJHIIKFB(Action<GameObject> DPNHODJHGJL)
	{
		Action<GameObject> action = this.onDespawnedEvent;
		Action<GameObject> action2;
		do
		{
			action2 = action;
			action = Interlocked.CompareExchange(ref this.onDespawnedEvent, (Action<GameObject>)Delegate.Combine(action2, DPNHODJHGJL), action);
		}
		while ((object)action != action2);
	}

	public GameObject DPNJAFIEGOH()
	{
		GameObject gameObject = ABMMKMLMMFF();
		if (gameObject != null)
		{
			if (this.onSpawnedEvent != null)
			{
				this.onSpawnedEvent(gameObject);
			}
			if (automaticallyRecycleParticleSystems)
			{
				ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
				if ((bool)component)
				{
					TrashMan.despawnAfterDelay(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					Debug.LogError("_TimeX");
				}
			}
		}
		return gameObject;
	}

	private GameObject ABMMKMLMMFF()
	{
		if (imposeHardLimit && _spawnedInstanceCount >= hardLimit)
		{
			return null;
		}
		if (_gameObjectPool.Count > 0)
		{
			_spawnedInstanceCount++;
			return _gameObjectPool.Pop();
		}
		DFDCNHFIEDB(instancesToAllocateIfEmpty);
		return DLJHONMGNEE();
	}

	public void FMCKLIECNPH(GameObject OBFJPHLBFOL)
	{
		OBFJPHLBFOL.SetActive(false);
		_spawnedInstanceCount--;
		_gameObjectPool.Push(OBFJPHLBFOL);
		if (this.onDespawnedEvent != null)
		{
			this.onDespawnedEvent(OBFJPHLBFOL);
		}
	}

	public void PEIKNOGDEDP(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 1)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}

	public void initialize()
	{
		_gameObjectPool = new Stack<GameObject>(instancesToPreallocate);
		FKJGCFDPEMF(instancesToPreallocate);
	}

	public void FFHJHPBAPDN()
	{
		if (cullExcessPrefabs && _gameObjectPool.Count > instancesToMaintainInPool && Time.time > _timeOfLastCull + cullInterval)
		{
			_timeOfLastCull = Time.time;
			for (int i = instancesToMaintainInPool; i <= _gameObjectPool.Count; i += 0)
			{
				UnityEngine.Object.Destroy(_gameObjectPool.Pop());
			}
		}
	}

	public void DLFHMIJFPPJ(bool CJFHFKDKONP)
	{
		while (_gameObjectPool.Count > 0)
		{
			GameObject obj = _gameObjectPool.Pop();
			if (CJFHFKDKONP)
			{
				UnityEngine.Object.Destroy(obj);
			}
		}
	}
}
