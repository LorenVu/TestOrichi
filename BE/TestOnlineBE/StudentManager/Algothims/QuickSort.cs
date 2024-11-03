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
            double pivot = students[right].AverageScore;
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (students[j].AverageScore > pivot)
                {
                    i++;
                    Swap(students, i, j);
                }
            }

            Swap(students, i + 1, right);
            return i + 1;
        }

        static void Swap(List<Student> students, int i, int j)
        {
            Student temp = students[i];
            students[i] = students[j];
            students[j] = temp;
        }
    }
}
