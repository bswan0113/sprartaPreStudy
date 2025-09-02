int[] numbers = { 10, 20, 30, 40, 50 };

void lv2(int[] numbers , ref int sum, out float avr)
{
    for (int i = 0; i < numbers.Count(); i++)
    {
        sum += numbers[i];
    }
    avr = (float)sum / numbers.Count();
}

int sum = 0;
float avr;
lv2(numbers, ref sum, out avr);

Console.WriteLine($"합계: {sum}");
Console.WriteLine($"평균: {avr}");




// ----------------------------------------gpt 답변------------------------------------------------------
// 반환 타입을 (int, float) 튜플로 지정
// (int, float) lv2_tuple(List<int> list)
// {
//     int sum = 0;
//     for (int i = 0; i < list.Count; i++)
//     {
//         sum += list[i];
//     }
//     float avr = (float)sum / list.Count;
//
//     return (sum, avr); // 계산된 두 값을 묶어서 반환
// }
//
// // 호출할 때
// var (total, average) = lv2_tuple(numbers); // 반환된 튜플을 각각의 변수로 바로 받음

// 1. 결과값을 담을 구조체를 정의
// public readonly struct CalculationResult
// {
//     public int Sum { get; }
//     public float Average { get; }
//
//     public CalculationResult(int sum, float average)
//     {
//         Sum = sum;
//         Average = average;
//     }
// }
//
// // 2. 메서드가 이 구조체를 반환하도록 수정
// CalculationResult lv2_struct(List<int> list)
// {
//     int sum = 0;
//     // ... 계산 로직은 동일 ...
//     float avr = (float)sum / list.Count;
//     return new CalculationResult(sum, avr);
// }
//
// // 3. 호출할 때
// CalculationResult result = lv2_struct(numbers);
// Console.WriteLine($"합계: {result.Sum}, 평균: {result.Average}");
