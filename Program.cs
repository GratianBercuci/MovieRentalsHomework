using MovieRentals;

var movieList = new List<Movie>();
movieList.Add(new Movie { Title = "\"500 days of Summer\"", Cost = 2, Points = 1, MovieType = "Regular" });
movieList.Add(new Movie { Title = "\"Matilda\"", Cost = 1.5m, Points=1, MovieType = "Childrens" });
movieList.Add(new Movie { Title = "\"Thor Love and Thunder\"", Cost = 3, Points = 2, MovieType = "New releases" });

for (int i=0; i < movieList.Count; i++)
{
    Console.WriteLine("Title:" + movieList[i].Title + " cost:" + movieList[i].Cost + " points:" +movieList[i].Points);
}



