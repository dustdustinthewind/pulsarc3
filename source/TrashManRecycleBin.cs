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
	public void MBCBIOCMMEC(Action<GameObject> DPNHODJHGJL)
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

	public void NCJECKOGBMA()
	{
		_gameObjectPool = new Stack<GameObject>(instancesToPreallocate);
		OBPPIMFFFEM(instancesToPreallocate);
	}

	public void JPLAIPFBHAN()
	{
		_gameObjectPool = new Stack<GameObject>(instancesToPreallocate);
		OBPPIMFFFEM(instancesToPreallocate);
	}

	[SpecialName]
	public void PPGNLCEJBHJ(Action<GameObject> DPNHODJHGJL)
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

	public void MKOHDGHAAFE()
	{
		_gameObjectPool = new Stack<GameObject>(instancesToPreallocate);
		OBPPIMFFFEM(instancesToPreallocate);
	}

	public void GBOFGDABKCM()
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

	public GameObject KCKBFNJODOO()
	{
		GameObject gameObject = CCKPGJEFMKB();
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
					Debug.LogError("_Value2");
				}
			}
		}
		return gameObject;
	}

	public void initialize()
	{
		_gameObjectPool = new Stack<GameObject>(instancesToPreallocate);
		FKJGCFDPEMF(instancesToPreallocate);
	}

	[SpecialName]
	public void NMLPCKOJFEB(Action<GameObject> DPNHODJHGJL)
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

	public GameObject OMEOOPEBFGA()
	{
		GameObject gameObject = CCKPGJEFMKB();
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
					Debug.LogError("\"\"");
				}
			}
		}
		return gameObject;
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

	[SpecialName]
	public void KGBFFMDGDBF(Action<GameObject> DPNHODJHGJL)
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
	public void MDCCCJHOELL(Action<GameObject> DPNHODJHGJL)
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
	public void HNLNIODGOPO(Action<GameObject> DPNHODJHGJL)
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
	public void DDLGCNABBBI(Action<GameObject> DPNHODJHGJL)
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
	public void HBBHMNCKPPP(Action<GameObject> DPNHODJHGJL)
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

	private void OBPPIMFFFEM(int HOHOIPHEOPN)
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
	public void DEGCAICEFEE(Action<GameObject> DPNHODJHGJL)
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

	[SpecialName]
	public void OCGAOLAAGNJ(Action<GameObject> DPNHODJHGJL)
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

	public void BKNEEPKKFEF()
	{
		_gameObjectPool = new Stack<GameObject>(instancesToPreallocate);
		OBPPIMFFFEM(instancesToPreallocate);
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

	public void LKBLCIKJEBE()
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
	public void CKIDNMGBKIO(Action<GameObject> DPNHODJHGJL)
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

	public GameObject PFCCGFEMMHJ()
	{
		GameObject gameObject = ENDIKIAKJJI();
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
					Debug.LogError("CameraFilterPack/Edge_Golden");
				}
			}
		}
		return gameObject;
	}

	private void BNECFOJNJJN(int HOHOIPHEOPN)
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
			gameObject.SetActive(false);
			_gameObjectPool.Push(gameObject);
		}
	}

	public void OONAAPDGBFG(GameObject OBFJPHLBFOL)
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
	public void PAFELDFIIKJ(Action<GameObject> DPNHODJHGJL)
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
	public void MMDHGNMNNMA(Action<GameObject> DPNHODJHGJL)
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
	public void FOCJCDCGEPB(Action<GameObject> DPNHODJHGJL)
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

	private GameObject HOKEHJCLOLD()
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
		return HOKEHJCLOLD();
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

	[SpecialName]
	public void EOKPJDOEGNB(Action<GameObject> DPNHODJHGJL)
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

	public void JPJKGNPDJJP()
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
	public void OKBIKIMKKFH(Action<GameObject> DPNHODJHGJL)
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

	public GameObject GDOMFJALCGG()
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
					TrashMan.IGBBPLOFEKG(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					Debug.LogError(". Using max value: 255.");
				}
			}
		}
		return gameObject;
	}

	[SpecialName]
	public void HJDNJHPKAOO(Action<GameObject> DPNHODJHGJL)
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

	public void MNOEAFIMPFO(bool CJFHFKDKONP)
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

	private GameObject ENDIKIAKJJI()
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
		return CNGNNAAMMEJ();
	}

	public GameObject LJKHLOGOCKA()
	{
		GameObject gameObject = HOKEHJCLOLD();
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
					Debug.LogError(" has no method \"");
				}
			}
		}
		return gameObject;
	}

	[SpecialName]
	public void IJBJMBMMEAP(Action<GameObject> DPNHODJHGJL)
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

	public void JIFDECHJFPN(bool CJFHFKDKONP)
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

	public void KOMLFNEAHEG()
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

	[SpecialName]
	public void OOGMDNLMLEF(Action<GameObject> DPNHODJHGJL)
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

	public GameObject ICPGHNOJBHF()
	{
		GameObject gameObject = ENDIKIAKJJI();
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
					TrashMan.IGBBPLOFEKG(gameObject, component.duration + component.startLifetime);
				}
				else
				{
					Debug.LogError("_Value5");
				}
			}
		}
		return gameObject;
	}

	private GameObject CCKPGJEFMKB()
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
		BNECFOJNJJN(instancesToAllocateIfEmpty);
		return CNGNNAAMMEJ();
	}

	public void AIOBACJJKOB()
	{
		_gameObjectPool = new Stack<GameObject>(instancesToPreallocate);
		BNECFOJNJJN(instancesToPreallocate);
	}

	[SpecialName]
	public void PPMHHIFPINC(Action<GameObject> DPNHODJHGJL)
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
}
