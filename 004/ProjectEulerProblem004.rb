startTime = Time.now
largestPalindrome = 0

def isPalindrome(value)
  return (value).to_s.eql?((value).to_s.reverse)
end

for leftHandSide in 900..999
  for rightHandSide in 900..999
    sum = leftHandSide * rightHandSide    
    if ((isPalindrome(sum)) and (sum > largestPalindrome))
      largestPalindrome = sum
    end
  end
end

puts "Largest Palindrome: " + (largestPalindrome).to_s
puts "Time took: " + (Time.now - startTime).to_s + " seconds"