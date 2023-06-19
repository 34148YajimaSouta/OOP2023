using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore(filePath);

            
        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            var student = new List<Student>();//売上データを格納
            var lines = File.ReadAllLines(filePath);//ファイルからすべてのデータを読み込む

            foreach (var line in lines) {//すべての行から1行ずつ取り出す
                var items = line.Split(',');
                var sale = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                student.Add(sale);
            }

            return student;
        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new SortedDictionary<string, int>();
            foreach (Student student in _score) {
                if (dict.ContainsKey(student.Name))
                    dict[student.Name] += student.Score;
                else
                    dict[student.Name] = student.Score;

            }
            return dict;
        }
    }
}
