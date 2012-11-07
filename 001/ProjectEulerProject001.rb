@sum = 0
@startTime = Time.now
for i in 1..999
  if ((i % 3 == 0) or (i % 5 ==0))
    @sum += i
  end
end
puts @sum
puts "Time took: " + (Time.now - @startTime).to_s + " seconds"