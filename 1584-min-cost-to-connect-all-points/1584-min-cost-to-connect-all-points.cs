public class Solution {
    class Point
	{
		public int from { get; set; }
		public int to { get; set; }
		public int val { get; set; }

	}
    
		List<int> par;
		private int find(int a)
		{
			if (par[a] == a) return a;
			else return find(par[a]);
		}
		public int MinCostConnectPoints(int[][] points)
		{

			int ans = 0;
			int n = points.Count();
			par = new List<int>();
			for (int i = 0; i < n; i++)
			{
				par.Add(i);
			}
			PriorityQueue<Point, int> pq = new PriorityQueue<Point, int>();

			for (int i = 0; i < n; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					int distance = Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);
					pq.Enqueue(new Point { from = i, to = j, val = distance }, distance);
				}
			}
			int connected = 0;
			while (connected < n-1)
			{
				Point point = pq.Dequeue();
				int s1 = find(point.from);
				int s2 = find(point.to);
				if (s1 != s2)
				{
					par[s1] = s2;
					ans += point.val;
					connected++;
				}
			}

			return ans;
		}
}