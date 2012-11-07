@sum = 2
@previousValue = 2
@nextValue = 3
@startTime = Time.now

for i in 1..100
  @temp = @nextValue
  @nextValue += @previousValue
  @previousValue = @temp

  if (@nextValue.even?)
    @sum += @nextValue    
  end
  if (@sum > 4000000)
    break
  end
end

puts @sum
puts "Time took: " + (Time.now - @startTime).to_s + " seconds"

