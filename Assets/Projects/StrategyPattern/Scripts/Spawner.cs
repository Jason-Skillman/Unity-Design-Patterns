namespace StrategyPattern
{
	using StrategyPattern.Strategies;
	using UnityEngine;

	public class Spawner : MonoBehaviour
	{
		[SerializeField]
		private GameObject prefab;
		[SerializeField]
		private SpawnStrategy spawnStrategy;

		private void Start()
		{
			for(int i = 0; i < 10; i++)
			{
				Spawn();
			}
		}

		private void Spawn()
		{
			GameObject go = Instantiate(prefab);

			Vector3 spawnPosition = spawnStrategy.SetPosition(transform.position);
			go.transform.position = spawnPosition;
		}
	}
}
