def run match
  puts "running\n\n"
  system("fsi ./program.fsx")
  puts "\ndone. [#{match}]"
end

watch ('.*.fsx$') { |md| run md[0] }
