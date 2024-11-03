using StudentManager.Entities;

namespace StudentManager.Algothims
{
    public static class QuickSort
    {
        public static void Sort(this List<Student> students, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(students, left, right);
                Sort(students, left, pivotIndex - 1);
                Sort(students, pivotIndex + 1, right);
            }
        }

        static int Partition(List<Student> students, int left, int right)
        {
            Student pivot = students[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (CompareStudents(students[j], pivot) < 0)
                {
                    i++;
                    Swap(students, i, j);
                }
            }

            Swap(students, i + 1, right);
            i++;

            return i;
        }

        static void Swap(List<Student> students, int i, int j)
        {
            Student temp = students[i];
            students[i] = students[j];
            students[j] = temp;
        }

        static int CompareStudents(Student a, Student b)
        {
            int scoreComparison = b.AverageScore.CompareTo(a.AverageScore);
            if (scoreComparison != 0)
            {
                return scoreComparison;
            }

            return a.Name.CompareTo(b.Name);
        }
    }
}
