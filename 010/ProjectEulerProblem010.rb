require 'mathn'

startTime = Time.now

sum = 0

for p in Prime.each(2000000)
  sum += p
end

puts "Sum of all prime numbers below 2 million is " + sum.to_s
puts "Time took: " + (Time.now - startTime).to_s + " seconds"