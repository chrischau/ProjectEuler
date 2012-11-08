startTime = Time.now

squareOfSum = 0
sumOfSquare = 0

for counter in 1..100   
  sumOfSquare += counter
  squareOfSum += counter * counter
end

puts "The difference: " + ((sumOfSquare * sumOfSquare) - squareOfSum).to_s
puts "Time took: " + (Time.now - startTime).to_s + " seconds"