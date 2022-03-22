using System.Linq;

namespace LINQApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 1, 2, 3, 4,3,5,3,2,4,2 };
            List<int> multipliedList = list.Multiply((x) => { return x * x; }).ToList();
            multipliedList.ForEach(x => Console.WriteLine(x));
            

            string[] findInList = new string[] { "blue", "yellow", "green", "blue", "red", "blue" };
            List<int> indexesInList = findInList.FindInArray("blue").ToList();
 
            indexesInList.ForEach(x => Console.Write($"{x} "));
            int concatenatedIntegerList = list.Concatenate((currentValue, x) => { return currentValue * x; });
            Console.WriteLine($"\n{concatenatedIntegerList}");

            string concatenatedStringList = findInList.Concatenate((currentValue, x) => { return currentValue + x; });
            Console.WriteLine($"\n{concatenatedStringList}");

            int combinedMultiplyAndConcatenate = list.Multiply(x => x*=2).Concatenate((currentValue,x)=>currentValue+=x);
            Console.WriteLine($"\n{combinedMultiplyAndConcatenate}");

            List<Student> students = new List<Student>() { new Student(1,22, "Ana"), new Student(1,25, "Maria"), new Student(1,22, "Ion"), new Student(2,25, "Flavius"), new Student(2,25,"Marius") };
            List<Facultate> faculties = new List<Facultate> { new Facultate(1, "Facultate1"), new Facultate(2, "Facultate2") };
            List<Student> selectStudents = (from student in students select student).ToList();
            selectStudents.ForEach((x) => { Console.WriteLine(x.Nume); });
            var studentsByIdFaculty = from student in students 
                                      group student by student.FacultyId into studentGroup
                                      select studentGroup;
            foreach(var group in studentsByIdFaculty)
            {
                Console.WriteLine("\nGroup key = "+group.Key);
                foreach(var student in group)
                {
                    Console.Write(student.ToString() + " ");
                }
            }

            var studentsJoinFaculty = from student in students
                                      join faculty in faculties on student.FacultyId equals faculty.FacultyId
                                      select new
                                      {
                                          faculty.FacultyId,
                                          faculty.FacultyName,
                                          student.Nume
                                      };
            Console.WriteLine("\n");
            foreach(var joinQuery in studentsJoinFaculty)
            {
                Console.WriteLine(joinQuery.FacultyId+" "+joinQuery.FacultyName+" "+joinQuery.Nume);
            }
            Console.WriteLine("\n\n ====================WHERE======================");
            students.Where(x=>x.Nume.StartsWith("M")).ToList().ForEach(x => Console.Write(x.ToString() + " "));
            Console.WriteLine("\n\n ====================TAKE======================");
            //take 
            list.Take(5).ToList().ForEach(x=>Console.Write(x+" "));
            Console.WriteLine("\n\n ====================TAKE WHILE======================");
            list.TakeWhile(x => x <3).ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine("\n\n ====================ORDER BY DESCENDING======================");
            students.OrderByDescending(x=>x.Varsta).ThenByDescending(x=>x.Nume).ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine("\n\n ====================REVERSE======================");
            list.Reverse().ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine("\n\n ====================SEQUENCE EQUAL======================");
            Console.WriteLine(list.SequenceEqual(new List<int> { 1, 2, 3, 4, 3, 5, 3, 2, 4, 2 }));
            Console.WriteLine(list.SequenceEqual(new List<int> { 1, 2, 3, 4, 3, 5, 3, 2, 4, 4}));
            Console.WriteLine(list.SequenceEqual(new List<int> { 12,7,9 }));
            Console.WriteLine("\n\n ====================SELECT======================");
            var olderStudents = from student in students
                                where student.Varsta > 23
                                select student;
            olderStudents.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("\n\n ====================DEFAULT IF EMPTY======================");
            List<string> defaults = new List<string>();
            var newDefaults = defaults.DefaultIfEmpty("uf1");
            newDefaults.ToList().ForEach(x => Console.WriteLine(x + " "));
            Console.WriteLine("\n\n ====================EMPTY======================");
            List<int> emptyList = Enumerable.Empty<int>().ToList();
            Console.WriteLine(emptyList.Count);
            Console.WriteLine("\n\n ====================RANGE======================");
            List<int> rangeList = Enumerable.Range(2000,30).ToList();
            rangeList.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine("\n\n ====================REPEAT======================");
            List<int> repeatList = Enumerable.Range(2000, 30).ToList();
            repeatList.ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine("\n\n ====================First======================");
            Console.WriteLine(findInList.First());
            Console.WriteLine("\n\n ====================First or Default======================");
            Console.WriteLine(findInList.FirstOrDefault("lolfnefi"));
            Console.WriteLine("\n\n ====================Last======================");
            Console.WriteLine(findInList.Last());
            Console.WriteLine("\n\n ====================Single======================");
            Console.WriteLine(findInList.Single(x=>x=="green"));
            Console.WriteLine("\n\n ====================Element At======================");
            Console.WriteLine(findInList.ElementAt(4));
            Console.WriteLine("\n\n ====================ToDictionary======================");
            Dictionary<string, int> dictionaryStudent = students.ToDictionary(x => x.Nume, y => y.Varsta);
            foreach(KeyValuePair<string, int> kvp in dictionaryStudent)
            {
                Console.WriteLine(kvp.Key+" "+ kvp.Value);
            }
           
            
            Console.WriteLine("\n\n ====================Average======================");
            Console.WriteLine(list.Average());

            Console.WriteLine("\n\n ====================Count======================");
            Console.WriteLine(list.Count());

            Console.WriteLine("\n\n ====================Max======================");
            Console.WriteLine(list.Max());

            Console.WriteLine("\n\n ====================Min======================");
            Console.WriteLine(list.Min());

            Console.WriteLine("\n\n ====================MaxBy======================");
            Console.WriteLine(students.MaxBy(x=>x.Varsta));

            Console.WriteLine("\n\n ====================Sum======================");
            Console.WriteLine(list.Sum());

            Console.WriteLine("\n\n ====================Distinct======================");
            List<int> setDistinct = list.Distinct().ToList();
            setDistinct.ForEach(x => Console.Write(x+" "));
            Console.WriteLine("\n\n ====================Except======================");
            List<int> setExcept = list.Except(new List<int>{ 2,3,5}).ToList();
            setExcept.ForEach(x => Console.Write(x + " "));
            Console.WriteLine("\n\n ====================Intersect======================");
            List<int> setIntersect = list.Intersect(new List<int> { 7,2, 3, 5,9 }).ToList();
            setIntersect.ForEach(x => Console.Write(x + " "));
            Console.WriteLine("\n\n ====================Union======================");
            List<int> setUnion = list.Union(new List<int> { 7, 2, 9,12,3 }).ToList();
            setUnion.ForEach(x => Console.Write(x + " "));
            Console.WriteLine("\n\n ====================Concat======================");
            List<int> setConcat = list.Concat(new List<int> { 7, 2, 9, 12, 3 }).ToList();
            setConcat.ForEach(x => Console.Write(x + " "));
            Console.WriteLine("\n\n ====================Skip======================");
            list.Skip(4).ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine("\n\n ====================SkipWhile======================");
            list.SkipWhile(x=>x<4).ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine("\n\n ====================Select======================");
            var numeFacultati = from faculty in faculties
                                         select faculty.FacultyName;
            numeFacultati.ToList().ForEach(x => Console.Write(x +" "));
            Console.WriteLine("\n\n ====================Select Many======================");
            List<Grupa> grupe = new List<Grupa>();
            Grupa grupa1 = new Grupa();
            Grupa grupa2 = new Grupa();
            grupa1.Students.Add(students[0]);
            grupa1.Students.Add(students[1]);
            grupa2.Students.Add(students[2]);
            grupa2.Students.Add(students[3]);
            grupe.Add(grupa1);
            grupe.Add(grupa2);
            var listaDeStudenti = grupe.SelectMany(x => x.Students);
            foreach (var student in listaDeStudenti)
            {
                Console.WriteLine("\n\n "+student.Nume);
                
            }
            Console.WriteLine("\n\n ====================JOIN======================");
            var joinValueList = from student in students
                            join faculty in faculties on student.FacultyId equals faculty.FacultyId
                            orderby student.Varsta descending
                            select new
                            {
                                faculty.FacultyId,
                                faculty.FacultyName,
                                student.Nume,
                                student.Varsta
                            };
            foreach(var joinValue in joinValueList)
            {
                Console.Write(joinValue.FacultyName + " " + joinValue.Nume + " " + joinValue.Varsta+", ");
            }
            Console.WriteLine("\n\n ====================GROUP JOIN======================");
            var groupJoin = from student in students
                            join faculty in faculties on student.FacultyId equals faculty.FacultyId into gr
                            select gr;
            foreach (var groupJoinValue in groupJoin)
            {
                Console.WriteLine(groupJoinValue.Count());
                foreach (var joinValue in groupJoinValue)
                {
                    Console.Write(joinValue.FacultyName);
                }
            }

            Console.WriteLine("\n\n ====================GROUP BY======================");
            var grouByList = from student in students
                             group student by student.FacultyId
                             into gr
                             select gr;
            foreach(var gr in grouByList)
            
           {
                Console.WriteLine(gr.Key);
                foreach(var student in gr)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            Console.WriteLine("\n\n ====================TO DICTIONARY======================");

            var dict = students.ToDictionary(x=>x.Nume, x=>x.Varsta);
            foreach (var student in dict)
            {
                Console.WriteLine(student.Key + " value: " + student.Value);
            }
                Console.WriteLine("\n\n ====================TO LOOKUP======================");
            var lookUp = students.ToLookup(x => x.FacultyId);
            foreach (var student in lookUp)
            {
                Console.WriteLine(student.Count());
                foreach (var student2 in student)
                {
                    Console.WriteLine(student2.ToString());
                }
            }
            Console.WriteLine("\n\n ====================ZIP======================");
            var strings = new string[] { "!", "@", "#", "$" };
            var vars = new string[] { "A", "B" };
            var zipValues = strings.Zip(vars,(s, i) => s + i);
            foreach(var zipValue in zipValues)
            {
                Console.WriteLine(zipValue);
            }

        }

    }
    public static class MultiplyExtensions
    {
        public static IEnumerable<T> Multiply<T>(this IEnumerable<T> arr, Func<T, T> predicate)
        {
            foreach (T item in arr)
            {
                yield return predicate(item);
            }
        }
    }
   
    public static class ConcatenateExtensions
    {
        public static T Concatenate<T>(this IEnumerable<T> arr, Func<T, T, T> predicate)
        {
            IEnumerator<T> enumerator = arr.GetEnumerator();
            enumerator.MoveNext();
            T concatValue = enumerator.Current;
            while (enumerator.MoveNext())
            {
                concatValue = predicate(concatValue, enumerator.Current);
            }
            return concatValue;

        }

    }


    public static class FindExtensions
    {
        public static IEnumerable<int> FindInArray<T>(this T[] arr, T value)
        {

            for(int i = 0; i < arr.Length; i++)
            {
                if (value.Equals(arr[i]))
                {
                    yield return i;
                }
            }


        }

    }

}