using UnityEngine;
using System.Collections.Generic;

public class ParticleEffectPool : MonoBehaviour
{
    public static ParticleEffectPool Instance { get; private set; }

    [System.Serializable]
    public class PoolItem
    {
        public string tag;
        public ParticleSystem prefab;
        public int size;
    }

    [SerializeField] private List<PoolItem> poolItems;

    private Dictionary<string, Queue<ParticleSystem>> poolDictionary;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        poolDictionary = new Dictionary<string, Queue<ParticleSystem>>();

        foreach (PoolItem item in poolItems)
        {
            Queue<ParticleSystem> objectPool = new Queue<ParticleSystem>();

            for (int i = 0; i < item.size; i++)
            {
                ParticleSystem obj = Instantiate(item.prefab);
                obj.gameObject.SetActive(false);
                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(item.tag, objectPool);
        }
    }

    public ParticleSystem SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning($"Pool with tag {tag} doesn't exist.");
            return null;
        }

        ParticleSystem objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.gameObject.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }
}