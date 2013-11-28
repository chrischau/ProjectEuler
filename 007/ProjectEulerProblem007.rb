require 'mathn'

startTime = Time.now

counter = 1
for p in Prime.instance
  counter += 1
  if (counter == 10001)
    puts "1001st prime: " + p.to_s
    break
  end
end

def sieve_of_eratosthenes(max)
  array = (2..max).to_a
  (2..Math::sqrt(max)).each do |i|
    array.delete_if { |a| a % i == 0 && a != i }
  end
  array
end

puts "Time took: " + (Time.now - startTime).to_s + " seconds"