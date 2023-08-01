public class Solution {
    public struct Vector2
	{
		public int x;
		public int y;
	}
	public int[][] KClosest(int[][] points, int k)
	{
		List<int[]> arrList = new List<int[]>();

		PriorityQueue<Vector2, double> pq = new PriorityQueue<Vector2, double>();

		for(int i=0;i<points.Length; i++)
		{
			double distance = Math.Sqrt(Math.Pow(points[i][0],2) + Math.Pow(points[i][1],2));
			pq.Enqueue(new Vector2 { x = points[i][0], y = points[i][1] },distance);	
		}

		for(int i=0;i<k;i++)
		{
			Vector2 point = pq.Dequeue();
			arrList.Add(new int[] { point.x, point.y });

		}
		return arrList.ToArray();
	}
}