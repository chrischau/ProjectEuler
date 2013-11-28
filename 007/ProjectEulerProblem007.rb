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

puts "Time took: " + (Time.now - startTime).to_s + " seconds"