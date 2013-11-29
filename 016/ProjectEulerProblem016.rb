@startTime = Time.now

def FindSum(value)
  @sum = 0
  value.to_s.chars.each { |i| @sum += i.to_i }
  
  return @sum
end

puts "the sum of the digits of the number 2^1000 is #{ FindSum(2 ** 1000).to_s }"

puts "Time took: " + (Time.now - @startTime).to_s + " seconds"