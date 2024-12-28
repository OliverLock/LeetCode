#include <iostream>
#include <ostream>
#include <vector>
class Solution {
public:
  std::vector<int> plusOne(std::vector<int> &digits) {
    bool carryOver = false;
    for (int i = digits.size() - 1; i >= 0; i--) {
      // Iterate backwards and check if it would go over 9 then carry over
      if (carryOver == true) {
        digits[i] += 1;
        carryOver = false;
      }
      if (i == digits.size() - 1) {
        digits[i] += 1;
      }
      if (digits[i] - 10 >= 0) {
        carryOver = true;
        digits[i] = digits[i] - 10;
      }
    }
    // For situation where final element in array needs carry over
    if (carryOver == true) {
      int numberHold = 0;
      for (int i = 0; i < digits.size(); i++) {
        if (i == 0) {
          numberHold = digits[i];
          digits[i] = 1;
        }
        if (i != 0) {
          int temp = digits[i];
          digits[i] = numberHold;
          numberHold = temp;
        }
        if (i == digits.size() - 1) {
          digits.push_back(0);
          return digits;
        }
      }
    }
    return digits;
  }
};

int main() {
  std::cout << "Running Soloution" << std::endl;
  Solution solution;
  std::vector<int> inputVector = {0,1,2,3,4,5,6};
  std::string test = "test";

  std::vector<int> data = solution.plusOne(inputVector);

  for (int num : data) {
    std::cout << num << "";
  }
  std::cout << std::endl;
  std::cout << std::endl;
  std::cout << "test" << std::endl;
  return 0;
}
